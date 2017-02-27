﻿
Option Strict On
Option Explicit On

Imports System.Runtime.InteropServices
Imports System.Text
Imports System.ComponentModel
Imports Microsoft.Win32.SafeHandles

Public Class cls_PhysicalDrive
#Region "Win32 Definitions"
    <StructLayout(LayoutKind.Sequential)> _
    Private Structure IDEREGS
        Public bFeaturesReg As Byte
        Public bSectorCountReg As Byte
        Public bSectorNumberReg As Byte
        Public bCylLowReg As Byte
        Public bCylHighReg As Byte
        Public bDriveHeadReg As Byte
        Public bCommandReg As Byte
        Public bReserved As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure SENDCMDINPARAMS
        Public cBufferSize As Int32
        Public irDriveRegs As IDEREGS
        Public bDriveNumber As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> _
        Public bReserved As Byte()
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Public dwReserved As Int32()
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1)> _
        Public bBuffer As Byte()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure DRIVERSTATUS
        Public bDriverError As Byte
        Public bIDEError As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> _
        Public bReserved As Byte()
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> _
        Public dwReserved As Int32()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure SENDCMDOUTPARAMS
        Public cBufferSize As Int32
        Public DriverStatus As DRIVERSTATUS
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=IDENTIFY_BUFFER_SIZE)> _
        Public bBuffer As Byte()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure GETVERSIONINPARAMS
        Public bVersion As Byte
        Public bRevision As Byte
        Public bReserved As Byte
        Public bIDEDeviceMap As Byte
        Public fCapabilities As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Public dwReserved As Int32()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure STORAGE_PROPERTY_QUERY
        Public PropertyId As Int32
        Public QueryType As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1)> _
        Public AdditionalParameters As Byte()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure STORAGE_DEVICE_DESCRIPTOR
        Public Version As Int32
        Public Size As Int32
        Public DeviceType As Byte
        Public DeviceTypeModifier As Byte
        Public RemovableMedia As Byte
        Public CommandQueueing As Byte
        Public VendorIdOffset As Int32
        Public ProductIdOffset As Int32
        Public ProductRevisionOffset As Int32
        Public SerialNumberOffset As Int32
        Public BusType As Byte
        Public RawPropertiesLength As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10240)> _
        Public RawDeviceProperties As Byte()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure SCSI_PASS_THROUGH
        Public Length As Int16
        Public ScsiStatus As Byte
        Public PathId As Byte
        Public TargetId As Byte
        Public Lun As Byte
        Public CdbLength As Byte
        Public SenseInfoLength As Byte
        Public DataIn As Byte
        Public DataTransferLength As Int32
        Public TimeOutValue As Int32
        Public DataBufferOffset As IntPtr
        Public SenseInfoOffset As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> _
        Public Cdb As Byte()
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure SCSI_PASS_THROUGH_WITH_BUFFER
        Public Spt As SCSI_PASS_THROUGH
        Public Filler As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> _
        Public Buffer As Byte()
    End Structure

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function CreateFile(ByVal lpFileName As String, ByVal dwDesiredAccess As Int32, ByVal dwShareMode As Int32, ByVal lpSecurityAttributes As IntPtr, ByVal dwCreationDisposition As Int32, ByVal dwFlagsAndAttributes As Int32, ByVal hTemplateFile As IntPtr) As SafeFileHandle
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function DeviceIoControl(ByVal hDevice As SafeFileHandle, ByVal dwIoControlCode As Int32, <[In]()> ByRef lpInBuffer As SENDCMDINPARAMS, ByVal nInBufferSize As Int32, <[In](), Out()> ByRef lpOutBuffer As SENDCMDOUTPARAMS, ByVal nOutBufferSize As Int32, ByRef lpBytesReturned As Int32, ByVal lpOverlapped As Int32) As Int32
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function DeviceIoControl(ByVal hDevice As SafeFileHandle, ByVal dwIoControlCode As Int32, ByVal lpInBuffer As IntPtr, ByVal nInBufferSize As Int32, <[In](), Out()> ByRef lpOutBuffer As GETVERSIONINPARAMS, ByVal nOutBufferSize As Int32, ByRef lpBytesReturned As Int32, ByVal lpOverlapped As Int32) As Int32
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function DeviceIoControl(ByVal hDevice As SafeFileHandle, ByVal dwIoControlCode As Int32, <[In]()> ByRef lpInBuffer As STORAGE_PROPERTY_QUERY, ByVal nInBufferSize As Int32, <[In](), Out()> ByRef lpOutBuffer As STORAGE_DEVICE_DESCRIPTOR, ByVal nOutBufferSize As Int32, ByRef lpBytesReturned As Int32, ByVal lpOverlapped As Int32) As Int32
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function DeviceIoControl(ByVal hDevice As SafeFileHandle, ByVal dwIoControlCode As Int32, <[In]()> ByRef lpInBuffer As SCSI_PASS_THROUGH_WITH_BUFFER, ByVal nInBufferSize As Int32, <[In](), Out()> ByRef lpOutBuffer As SCSI_PASS_THROUGH_WITH_BUFFER, ByVal nOutBufferSize As Int32, ByRef lpBytesReturned As Int32, ByVal lpOverlapped As Int32) As Int32
    End Function

    Private Const OPEN_EXISTING As Int32 = 3
    Private Const GENERIC_READ As Int32 = &H80000000
    Private Const GENERIC_WRITE As Int32 = &H40000000
    Private Const FILE_SHARE_READ As Int32 = &H1
    Private Const FILE_SHARE_WRITE As Int32 = &H2
    Private Const FILE_SHARE_DELETE As Int32 = &H4
    Private Const SMART_GET_VERSION As Int32 = &H74080
    Private Const SMART_RCV_DRIVE_DATA As Int32 = &H7C088
    Private Const ID_CMD As Int32 = &HEC
    Private Const IDENTIFY_BUFFER_SIZE As Int32 = 512
    Private Const CAP_SMART_CMD As Int32 = &H4
    Private Const IOCTL_STORAGE_QUERY_PROPERTY As Int32 = &H2D1400
    Private Const IOCTL_SCSI_PASS_THROUGH As Int32 = &H4D004
    Private Const SCSI_IOCTL_DATA_IN As Int32 = &H1
    Private Const PropertyStandardQuery As Int32 = 0
    Private Const StorageDeviceProperty As Int32 = 0
    Private Const ERROR_INVALID_FUNCTION As Int32 = &H1
#End Region

    Public Shared Function GetSerialNumberUsingStorageQuery(ByVal diskNumber As Integer) As String
        Using hDisk As SafeFileHandle = OpenDisk(diskNumber)
            Dim iBytesReturned As Int32
            Dim spq As New STORAGE_PROPERTY_QUERY()
            Dim sdd As New STORAGE_DEVICE_DESCRIPTOR()
            spq.PropertyId = StorageDeviceProperty
            spq.QueryType = PropertyStandardQuery

            If DeviceIoControl(hDisk, IOCTL_STORAGE_QUERY_PROPERTY, spq, Marshal.SizeOf(spq), sdd, Marshal.SizeOf(sdd), iBytesReturned, 0) = 0 Then
                Throw CreateWin32Exception(Marshal.GetLastWin32Error(), "DeviceIoControl(IOCTL_STORAGE_QUERY_PROPERTY)")
            End If

            Dim result As New StringBuilder()
            If sdd.SerialNumberOffset > 0 Then
                Dim rawDevicePropertiesOffset As Integer = Marshal.SizeOf(sdd) - sdd.RawDeviceProperties.Length
                Dim pos As Integer = sdd.SerialNumberOffset - rawDevicePropertiesOffset
                While pos < iBytesReturned And sdd.RawDeviceProperties(pos) <> 0
                    result.Append(Encoding.ASCII.GetString(sdd.RawDeviceProperties, pos, 1))
                    pos += 1
                End While
            End If
            Return result.ToString().Trim()
        End Using
    End Function

    Public Shared Function GetSerialNumberUsingSmart(ByVal diskNumber As Integer) As String
        Using hDisk As SafeFileHandle = OpenDisk(diskNumber)
            If IsSmartSupported(hDisk) Then
                Dim iBytesReturned As Int32
                Dim sci As New SENDCMDINPARAMS
                Dim sco As New SENDCMDOUTPARAMS
                sci.irDriveRegs.bCommandReg = ID_CMD
                sci.bDriveNumber = CByte(diskNumber)
                sci.cBufferSize = IDENTIFY_BUFFER_SIZE
                If DeviceIoControl(hDisk, SMART_RCV_DRIVE_DATA, sci, Marshal.SizeOf(sci), sco, Marshal.SizeOf(sco), iBytesReturned, 0) = 0 Then
                    Throw CreateWin32Exception(Marshal.GetLastWin32Error(), "DeviceIoControl(SMART_RCV_DRIVE_DATA)")
                End If
                Dim result As New StringBuilder()
                For index As Integer = 20 To 39 Step 2
                    result.Append(Encoding.ASCII.GetString(sco.bBuffer, index + 1, 1))
                    result.Append(Encoding.ASCII.GetString(sco.bBuffer, index, 1))
                Next
                Return result.ToString().Trim()
            Else
                Return String.Empty
            End If
        End Using
    End Function
    Public Shared Function GetSerialNumberUsingScsiPassThrough(ByVal diskNumber As Integer) As String
        Using hDisk As SafeFileHandle = OpenDisk(diskNumber)
            Dim iBytesReturned As Int32
            Dim spt As New SCSI_PASS_THROUGH_WITH_BUFFER
            spt.Spt.Length = CShort(Marshal.SizeOf(spt.Spt))
            spt.Spt.CdbLength = 16
            spt.Spt.DataIn = SCSI_IOCTL_DATA_IN
            spt.Spt.DataTransferLength = 64
            spt.Spt.DataBufferOffset = New IntPtr(Marshal.SizeOf(spt) - 64)
            spt.Spt.TimeOutValue = 60
            Dim cdb(15) As Byte
            cdb(0) = &H12 ' INQUIRY
            cdb(1) = &H1 ' EVPD bit
            cdb(2) = &H80 ' Page code (indicates Serial Number)
            cdb(4) = 64 ' Allocation length
            spt.Spt.Cdb = cdb
            If DeviceIoControl(hDisk, IOCTL_SCSI_PASS_THROUGH, spt, Marshal.SizeOf(spt), spt, Marshal.SizeOf(spt), iBytesReturned, 0) = 0 Then
                Dim iErrorCode As Int32 = Marshal.GetLastWin32Error()
                If iErrorCode <> ERROR_INVALID_FUNCTION Then
                    Throw CreateWin32Exception(iErrorCode, "DeviceIoControl(IOCTL_SCSI_PASS_THROUGH)")
                End If
            End If
            Dim result As New StringBuilder()
            Dim pos As Integer = IntPtr.Size
            While pos < spt.Spt.DataTransferLength And spt.Buffer(pos) <> 0
                result.Append(Encoding.ASCII.GetString(spt.Buffer, pos, 1))
                pos += 1
            End While
            Return result.ToString().Trim()
        End Using
    End Function

    Private Shared Function CreateWin32Exception(ByVal errorCode As Int32, ByVal context As String) As Win32Exception
        Dim win32Exception As New Win32Exception(errorCode)
        win32Exception.Data("Context") = context
        Return win32Exception
    End Function

    Private Shared Function OpenDisk(ByVal diskNumber As Integer) As SafeFileHandle
        Dim hDevice As SafeFileHandle = CreateFile(String.Format("\\.\PhysicalDrive{0}", diskNumber), GENERIC_READ Or GENERIC_WRITE, FILE_SHARE_READ Or FILE_SHARE_WRITE Or FILE_SHARE_DELETE, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero)
        If (Not hDevice.IsInvalid) Then
            Return hDevice
        Else
            Throw CreateWin32Exception(Marshal.GetLastWin32Error(), "CreateFile")
        End If
    End Function

    Private Shared Function IsSmartSupported(ByVal hDisk As SafeFileHandle) As Boolean
        Dim iBytesReturned As Int32
        Dim gvi As New GETVERSIONINPARAMS
        If DeviceIoControl(hDisk, SMART_GET_VERSION, IntPtr.Zero, 0, gvi, Marshal.SizeOf(gvi), iBytesReturned, 0) = 0 Then
            Return False
        End If
        Return (gvi.fCapabilities And CAP_SMART_CMD) > 0
    End Function
End Class
