<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_LoadReport.aspx.vb"
    Inherits="frm_LoadReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>BÁO CÁO BÁN HÀNG</title>
    <link href="css/bootstrap3.2.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <link href="css/jquery-ui.min.css" rel="stylesheet">

    <script src="js/jquery-1.11.1.min.js" type="text/javascript"></script>

    <script src="js/jquery-ui.min.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);

            function EndRequestHandler(sender, args) {
                $('#fromday, #today').datepicker({
                    dateFormat: 'dd/mm/yy',
                    changeMonth: true,
                    changeYear: true,
                    duration: '',
                    showTime: true,
                    constrainInput: false
                }).datepicker('setDate', 'today');
            }

            var iOS = (navigator.userAgent.match(/(iPad|iPhone|iPod)/g) ? true : false);
            if (iOS = true) {
                $('#fromday, #today').datepicker({
                    dateFormat: 'dd/mm/yy',
                    changeMonth: true,
                    changeYear: true,
                    duration: '',
                    showTime: true,
                    constrainInput: false
                }).datepicker('setDate', 'today');

                //}).datepicker('update', new Date);
            }
            else {
                $('#fromday, #today').datepicker({
                    dateFormat: 'dd/mm/yy',
                    changeMonth: true,
                    changeYear: true,
                    duration: '',
                    showTime: true,
                    constrainInput: false
                }).datepicker('setDate', 'today');

                //}).datepicker('update', new Date);
            }
        });
          </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <Triggers>
   <asp:AsyncPostBackTrigger ControlID="CrystalReportViewer1" />
  </Triggers>
  <ContentTemplate>
    <div id="content">
        <div class="container-fluid">
            <div class="wrap_table_form">
                <div class="wrap_form_filter_top">
                    <div class="form-inline text-right" role="form">
                        <div class="form-group form_filter_top">
                            <label>
                                Báo cáo</label>
                            <asp:DropDownList ID="DropBaoCao" CssClass="form-control" runat="server">
                              <asp:ListItem Value="TaiChinhTONG">BÁO CÁO TÀI CHÍNH TỔNG</asp:ListItem>
                                <asp:ListItem Value="TaiChinh">BÁO CÁO TÀI CHÍNH CHI TIẾT</asp:ListItem>
                                <asp:ListItem Value="BCTIEPKHACH">BÁO CÁO TIẾP KHÁCH</asp:ListItem>
                                <asp:ListItem Value="CTHoaDon">BÁO CÁO CHI TIẾT HÓA ĐƠN</asp:ListItem>
                                 <asp:ListItem Value="BCTangHoaDon">BÁO CÁO TẶNG HÀNG</asp:ListItem>
                                 <asp:ListItem Value="BCHUYBAN">BÁO CÁO HỦY BÀN</asp:ListItem>
                                <asp:ListItem Value="HoaDon">BÁO CÁO HÓA ĐƠN</asp:ListItem>
                                <asp:ListItem Value="ThuChi">BÁO CÁO THU CHI</asp:ListItem>
                                <asp:ListItem Value="TraHang">BÁO CÁO TRẢ HÀNG</asp:ListItem>
                                <asp:ListItem Value="CongNo">BÁO CÁO CÔNG NỢ</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group form_filter_top">
                            <label>
                                Nhân viên</label>
                            <asp:DropDownList ID="DropNhanvien" CssClass="form-control" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group form_filter_top">
                            <label>
                                Từ ngày :
                            </label>
                            <input class="form-control input-sm" type="text" runat="server" id="fromday">
                            
                        </div>
                        <div class="form-group form_filter_top">
                            <label>
                                Đến ngày :
                            </label>
                            
                            <input class="form-control input-sm" type="text" runat="server" id="today">
                        </div>
                        <div class="form-group form_filter_top">
                            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-success btn-sm form_filter_top_btn"
                                Text="XEM BÁO CÁO" />
                        </div>
                        <div class="form-group form_filter_top">
                            <asp:Button ID="btnThoat" runat="server" CssClass="btn btn-danger btn-sm form_filter_top_btn"
                                Text="THOÁT" />
                        </div>
                    </div>
                </div>
            </div>
            <!-- end .wrap_table_form -->
             <div style="text-align: center;" >
            <CR:CrystalReportViewer  ID="CrystalReportViewer1" runat="server"
                AutoDataBind="true" Width="100%" />
        </div>
        </div>
       
    </div>
    <!-- end #content -->
      </ContentTemplate>
      </asp:UpdatePanel>
    </form>
</body>
</html>
