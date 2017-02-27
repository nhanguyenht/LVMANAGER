Public Class frm_sales_detail 

    Private Sub frm_sales_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gvByte_Language = 1 Then
            lblidinvo.Text = "SỐ HÓA ĐƠN:"
            lblkh.Text = "KHÁCH HÀNG:"
            lblTotalText.Text = "TỔNG CỘNG:"
            lblDiscountText.Text = "GIẢM GIÁ:"
            lblFinalCostText.Text = "THÀNH TIỀN:"
            Me.Text = "THÔNG TIN CHI TIẾT"
        Else
            Me.Text = "DETAILS"
            lblidinvo.Text = "INVOICE NO:"
            lblkh.Text = "CUSTOMER:"
            lblTotalText.Text = "TOTAL:"
            lblDiscountText.Text = "DISCOUNT:"
            lblFinalCostText.Text = "TO CASH:"
        End If
    End Sub
End Class