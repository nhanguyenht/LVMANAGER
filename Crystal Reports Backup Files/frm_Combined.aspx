<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_Combined.aspx.vb" Inherits="frm_Combined" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>GỘP BÀN</title>

    <link href="css/bootstrap-3.2.0.min.css" rel="stylesheet">
    <%--<link href='http://fonts.googleapis.com/css?family=Open+Sans&subset=vietnamese' rel='stylesheet' type='text/css'>--%>
    <link href="css/style.css" rel="stylesheet">
<link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <script src="js/jquery-1.11.1.min.js"></script>
    <script src="js/bootstrap-3.2.0.min.js"></script>

    <script type="text/javascript">
        function InsertItem(itemid) {
            $.ajax({
                type: "POST",
                url: "frm_Split.aspx/InsertItemOrder",
                data: "{itemid:'" + itemid + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "json",
                success: function (msg) { }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn_chiahet" />
                <asp:AsyncPostBackTrigger ControlID="btn_trahet"></asp:AsyncPostBackTrigger>
                <asp:AsyncPostBackTrigger ControlID="btn_chia"></asp:AsyncPostBackTrigger>
                <asp:AsyncPostBackTrigger ControlID="btn_tra"></asp:AsyncPostBackTrigger>
            </Triggers>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn_trahet" />
            </Triggers>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn_chia" />
            </Triggers>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn_tra" />
            </Triggers>
            <ContentTemplate>
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
                            <h3 class="h3_form_chia">Gộp bàn</h3>
                            <div class="row">
                                <div class="col-md-5 table_col_1">
                                    <div class="form-inline">
                                        <div class="form-group">
                                            <label>Bàn</label>
                                            <%--<input type="text" class="form-control" value="7">--%>
                                            <asp:TextBox runat="server" ID="txt_fban" Text="" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <table class="table table-bordered table_custom_chia">
                                        <asp:Repeater ID="DataList_from" runat="server">
                                            <HeaderTemplate>
                                                <tr class="table_order_th">
                                                    <th width="30%">Tên hàng</th>
                                                    <th width="10%">SL</th>
                                                    <th width="20%">Giá</th>
                                                    <th width="25%" style="display: none">SL chuyển</th>
                                                </tr>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <%--<%#Eval("Tên hàng")%>--%>
                                                        <asp:Label ID="lbl_tenhang" runat="server" Text='<%#Eval("Tên hàng")%>'></asp:Label>
                                                    </td>
                                                    <td>
                                                        <%--<%#Eval("SL")%>--%>
                                                        <asp:Label ID="lbl_sl" runat="server" Text='<%#Eval("SL")%>'></asp:Label>
                                                    </td>
                                                    <td>
                                                        <%--<%#Eval("Giá")%>--%>
                                                        <asp:Label ID="lbl_dongia" runat="server" Text='<%#Eval("Giá")%>'></asp:Label>
                                                    </td>
                                                    <td style="display: none">
                                                        <asp:TextBox ID="txt_sl" runat="server" Width="50px" Text='<%#Eval("SL")%>'></asp:TextBox>
                                                        <asp:CheckBox ID="chb_chuyen" runat="server" Width="50px" Checked="true" />
                                                        <asp:Label ID="lbl_itemid" runat="server" Text='<%#Eval("Item_ID")%>' ToolTip='<%#Eval("STT")%>' Visible="false"></asp:Label>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </table>
                                </div>

                                <div class="col-md-2 table_col_2">
                                    <ul class="list-inline action_btn_ul action_btn_ul_chia">
                                        <li>
                                            <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut8"></button>--%>
                                            <%--<asp:Button ID="btn_chia" runat="server" Text="" CssClass="action_btn_ul_inbut action_btn_ul_inbut8" />--%>
                                            <asp:Button ID="btn_chia" runat="server" Text="" CssClass="action_btn_ul_inbut action_btn_ul_inbut9" />
                                        </li>
                                        <li style="display: none;">
                                            <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut9"></button>--%>
                                            <asp:Button ID="btn_chiahet" runat="server" Text="" CssClass="action_btn_ul_inbut action_btn_ul_inbut9" />
                                        </li>
                                        <li>
                                            <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut10"></button>--%>
                                            <%--<asp:Button ID="btn_tra" runat="server" Text="" CssClass="action_btn_ul_inbut action_btn_ul_inbut10" />--%>
                                            <asp:Button ID="btn_tra" runat="server" Text="" CssClass="action_btn_ul_inbut action_btn_ul_inbut11 " />
                                        </li>
                                        <li style="display: none;">
                                            <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut11"></button>--%>
                                            <asp:Button ID="btn_trahet" runat="server" Text="" CssClass="action_btn_ul_inbut action_btn_ul_inbut11" />
                                        </li>
                                        <li>
                                            <asp:Button ID="btnThoat" runat="server" CssClass="action_btn_ul_inbut action_btn_ul_inbut4" Text="Thoát" />
                                        </li>
                                    </ul>
                                </div>

                                <div class="col-md-5 table_col_1">
                                    <div class="form-inline">
                                        <div class="form-group">
                                            <label>Bàn</label>
                                            <%--<input type="text" class="form-control" value=''>--%>
                                            <asp:TextBox runat="server" ID="txt_tban" Text="" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <table class="table table-bordered table_custom_chia">
                                        <asp:Repeater ID="DataList_to" runat="server">
                                            <HeaderTemplate>
                                                <tr class="table_order_th">
                                                    <th width="30%">Tên hàng</th>
                                                    <th width="10%">SL</th>
                                                    <th width="20%">Giá</th>
                                                    <th width="25%" style="display: none">SL chuyển</th>
                                                </tr>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <%--<%#Eval("Tên hàng")%>--%>
                                                        <asp:Label ID="lbl_tenhang" runat="server" Text='<%#Eval("Tên hàng")%>'></asp:Label>
                                                    </td>
                                                    <td>
                                                        <%#Eval("SL")%>
                                                    </td>
                                                    <td>
                                                        <%--<%#Eval("Giá")%>--%>
                                                        <asp:Label ID="lbl_dongia" runat="server" Text='<%#Eval("Giá")%>'></asp:Label>
                                                    </td>
                                                    <td style="display: none">
                                                        <asp:TextBox ID="txt_sl" runat="server" Width="50px" Text='<%#Eval("SL")%>'></asp:TextBox>
                                                        <asp:CheckBox ID="chb_chuyen" runat="server" Width="50px" Checked="true" />
                                                        <asp:Label ID="lbl_itemid" runat="server" Text='<%#Eval("Item_ID")%>' ToolTip='<%#Eval("STT")%>' Visible="false"></asp:Label>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </table>                                    
                                </div>
                            </div>
                            <div class="row row_table_chia" style="display: none;">
                                <div class="col-md-5 table_col_1">
                                    <ul class="list-inline action_btn_ul action_btn_ul_chia">
                                        <li>
                                            <button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut12"></button>
                                        </li>
                                        <li>
                                            <button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut13"></button>
                                        </li>
                                    </ul>
                                </div>
                                <div class="col-md-2 table_col_2">
                                    <ul class="list-inline action_btn_ul action_btn_ul_chia">
                                        <li>
                                            <button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut4">Thoát</button>
                                        </li>
                                    </ul>
                                </div>
                                <div class="col-md-5 table_col_1">
                                    <ul class="list-inline action_btn_ul action_btn_ul_chia">
                                        <li>
                                            <%--<button type="submit" class="action_btn_ul_inbut action_btn_ul_inbut12"></button>--%>
                                        </li>
                                        <li>
                                            <%--<asp:Button ID="btnThoat" runat="server" CssClass="action_btn_ul_inbut action_btn_ul_inbut13" />--%>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </form>
                    </div>
                    <!-- end #content -->

                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <!-- end .container-fluid -->
    </form>
</body>
</html>
