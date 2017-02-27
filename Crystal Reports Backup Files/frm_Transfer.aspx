<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_Transfer.aspx.vb" Inherits="frm_Transfer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <title>CHUYỂN BÀN</title>

    <link href="css/bootstrap-3.2.0.min.css" rel="stylesheet">
   <%-- <link href='http://fonts.googleapis.com/css?family=Open+Sans&subset=vietnamese' rel='stylesheet' type='text/css'>--%>
    <link href="css/style.css" rel="stylesheet">

    <script src="js/jquery-1.11.1.min.js"></script>
    <script src="js/bootstrap-3.2.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <header id="header">
        <h4>Khách hàng của chúng tôi</h4>

        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">

          <!-- Wrapper for slides -->
          <div class="carousel-inner" role="listbox">
            <div class="item item_slide_custom active">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/logo.png"></li>
                <li class="text-left item_slide2">
                  <p>HULA BEER CLUB</p>
                  <p>Beer Club</p>
                  <p>321A Phạm Văn Đồng, Phường 3, Quận Gò Vấp</p>
                </li>
              </ul>
            </div>
            <div class="item item_slide_custom">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/logo.png"></li>
                <li class="text-left item_slide2">
                  <p>HULA BEER CLUB</p>
                  <p>Beer Club</p>
                  <p>321A Phạm Văn Đồng, Phường 3, Quận Gò Vấp</p>
                </li>
              </ul>
            </div>
            <div class="item item_slide_custom">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/logo.png"></li>
                <li class="text-left item_slide2">
                  <p>HULA BEER CLUB</p>
                  <p>Beer Club</p>
                  <p>321A Phạm Văn Đồng, Phường 3, Quận Gò Vấp</p>
                </li>
              </ul>
            </div>
          </div>

          <!-- Controls -->
          <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
          </a>
          <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
          </a>
        </div>

      </header>
            <!-- end #header -->
            <div id="content">
                <form>
                    <h3 class="h3_form_chia">Chuyển bàn</h3>
                    <div class="row">
                        <div class="col-md-6 table_col_3">
                            <table class="table table-bordered table_custom_chia">
                                <asp:Repeater ID="DataList_from" runat="server">
                                    <HeaderTemplate>
                                        <tr class="table_order_th">
                                            <th width="30%">Tên hàng</th>
                                            <th width="10%">SL</th>
                                            <th width="20%">Giá</th>
                                            <%--<th width="25%">SL chuyển</th>--%>
                                        </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td><%--<%#Eval("Tên hàng")%>--%>
                                                <asp:Label ID="lbl_tenhang" runat="server" Text='<%#Eval("Tên hàng")%>'></asp:Label>
                                            </td>
                                            <td><%--<%#Eval("SL")%>--%>
                                                <asp:Label ID="lbl_sl" runat="server" Text='<%#Eval("SL")%>'></asp:Label>
                                            </td>
                                            <td><%--<%#Eval("Giá")%>--%>
                                                <asp:Label ID="lbl_dongia" runat="server" Text='<%#Eval("Giá")%>'></asp:Label>
                                            </td>
                                            <%--<td>
                                            <asp:TextBox ID="txt_sl" runat="server" Text="1" Width="50px"></asp:TextBox>
                                            <asp:CheckBox ID="chb_chuyen" runat="server" Width="50px" />
                                            <asp:Label ID="lbl_itemid" runat="server" Text='<%#Eval("Item_ID")%>' Visible="false"></asp:Label>
                                        </td>--%>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </table>                            
                        </div>

                        <div class="col-md-6 table_col_3">
                            <div class="form-inline label_form_chia">
                                <label>Từ bàn</label>
                                <%--<input type="text" class="form-control" value="7">--%>
                                <asp:TextBox ID="txt_fban" runat="server" CssClass="form-control" ReadOnly="true" Text=""></asp:TextBox>
                            </div>
                            <p class="text-center">
                                <img src="images/btn_icon_12.png">
                            </p>
                            <div class="form-inline label_form_chia">
                                <label>Đến bàn</label>
                                <%--<input type="text" class="form-control" value="2">--%>
                                <asp:TextBox ID="txt_tban" runat="server" CssClass="form-control" ReadOnly="true" Text=""></asp:TextBox>
                            </div>

                            <ul class="list-inline action_btn_ul action_btn_ul_chuyen">
                                <li>
                                    <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut3">Xác nhận</button>--%>
                                    <asp:Button ID="btn_confirm" runat="server" CssClass="action_btn_ul_inbut action_btn_ul_inbut3" Text="Xác nhận" />
                                </li>
                                <li>
                                    <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut4">Thoát</button>--%>
                                    <asp:Button ID="btnThoat" runat="server" CssClass="action_btn_ul_inbut action_btn_ul_inbut4" Text="Thoát" />
                                </li>
                            </ul>
                        </div>
                    </div>

                </form>
            </div>
            <!-- end #content -->

        </div>
        <!-- end .container-fluid -->
    </form>
</body>
</html>
