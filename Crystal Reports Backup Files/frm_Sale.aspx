<%@ Page Language="VB" EnableEventValidation="false" AutoEventWireup="false" CodeFile="frm_Sale.aspx.vb" Inherits="frm_Sale" %>

<%@ Import Namespace="System.Drawing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Giao Diện Bán Hàng</title>
    <link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <link href="css/bootstrap-3.2.0.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />
    <link href="css/style.css" rel="stylesheet"/>

    <script src="js/jquery-1.11.1.min.js"></script>

    <script src="js/bootstrap-3.2.0.min.js"></script>

    <!--============================================-->

    <script defer src="js/jquery.flexslider.js"></script>
    <script type="text/javascript">
        function CheckJavascriptFunction() {
            alert("Đã sent order thành công");

            window.location.href = "frm_Table.aspx";
        }
    </script>
    <script type="text/javascript">
        var groupid = "01";
        var loaibanphim;
        function loadArare() {
            $('.flexslider').flexslider({
                animation: "slide",
                animationLoop: false,
                itemWidth: 105,
                itemMargin: 5,
                prevText: "",
                nextText: "",
                slideshow: false,
                start: function(slider) {
                    $('body').removeClass('loading');
                }
            });

            $("#Grouphdt_" + groupid).addClass("active");

            $("#manhomhanghoa_" + groupid).addClass("active");

            if (groupid != "01") {
                $('#Grouphdt_01').removeClass('active');
                $('#manhomhanghoa_01').removeClass('active');
            }
        }

        $(document).ready(function() {
            function hienThiItemOrder() {
                var tableid = "0";

                var queryString = [];
                var hash;
                var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
                for (var i = 0; i < hashes.length; i++) {
                    hash = hashes[i].split('=');
                    queryString.push(hash[1]);
                }

                tableid = queryString;

                $.ajax({
                    type: "POST",
                    url: "frm_Sale.aspx/ShowItemOrder",
                    data: "{tableidjq:'" + tableid + "'}",
                    contentType: "application/json; charset=utf-8",
                    async: true,
                    cache: false,
                    dataType: "text",
                    success: function(data) {
                        dienDuLieuVaoGrid(data);
                    }
                });
            }

            hienThiItemOrder();
            hienThiGiaTienTrongGrid();
            loadArare();
        });
    </script>

    <!--============================================-->

    <script type="text/javascript">
        var actv = "";
        var qty = 1;
        var chuoi = "";
        var monmo = false;
        function InsertItemID(itemid,soluong) {
            
            qty = qty.toString().replace(".", ",");
                   
            if (parseFloat(qty) > 0) {
                var tableid = "0";
              
                var queryString = [];
                var hash;
                var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
                for (var i = 0; i < hashes.length; i++) {
                    hash = hashes[i].split('=');
                    queryString.push(hash[1]);
                }
                
                tableid = queryString;
                $.ajax({
                    type: "POST",
                    url: "frm_Sale.aspx/InsertItemOrder",
                    data: "{itemid:'" + itemid + "',qty:'" + qty + "',tableidjq:'" + tableid + "'}",
                    contentType: "application/json; charset=utf-8",
                    async: true,
                    cache: false,
                    dataType: "text",
                    success: function(data) {
                        dienDuLieuVaoGrid(data);
                        hienThiGiaTienTrongGrid();

                        hienThiThongTinSales();

                        refreshQty();
                        // thiet lap active
                        $(".btn_item").removeClass("active_item");
                        $("#btn_" + itemid).addClass("active_item");
                    }
                });
            }
            else {
                refreshQty();
                alert("Số lượng phải lớn hơn 0");
            }
        }

        function hienThiThongTinSales() {
            var tableid = "0";

            var queryString = [];
            var hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                queryString.push(hash[1]);
            }

            tableid = queryString;

            $.ajax({
                type: "POST",
                url: "frm_Sale.aspx/GetInfoSales",
                data: "{tableidjq:'" + tableid + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "text",
                success: function(data) {
                    try {
                        var dataJson = JSON.parse(JSON.parse(data).d);
                        $("#txtSoHD").val(dataJson[0]["id"]);
                        $("#txtTable").val(dataJson[0]["name"]);
                        $("#txtNhanVien").val(dataJson[0]["CASHIER_ID"]);
                    } catch (ex) { }
                }
            });
        }

        function hienThiGiaTienTrongGrid() {
            var tableid = "0";

            var queryString = [];
            var hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                queryString.push(hash[1]);
            }

            tableid = queryString;

            $.ajax({
                type: "POST",
                url: "frm_Sale.aspx/GetPriceItemOrderByTblID",
                data: "{tableidjq:'" + tableid + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "text",
                success: function(data) {
                    dienGiaVaoGrid(data);
                }
            });
        }

        function dienGiaVaoGrid(data) {
            try {
                var dataJson = JSON.parse(JSON.parse(data).d);

                $("#thTongCong").text(dataJson[0]["TOTAL"].toLocaleString());
                $("#thGiamGia").text(dataJson[0]["DISCOUNT"].toLocaleString());
                $("#thPhiDichVu").text(dataJson[0]["SERVICE"].toLocaleString());
                $("#thVAT").text(dataJson[0]["VAT"].toLocaleString());
                $("#thThanhTien").text(dataJson[0]["TOTALCOST"].toLocaleString());
            } catch (ex) { }
        }

        function dienDuLieuVaoGrid(data) {
            try {
                var dataJson = JSON.parse(JSON.parse(data).d);
                $("#ItemOrder").html("");
                
                var html = "";
                for (var i = 0; i < dataJson.length; i++) {
                    html += "<tr>";
                    html += "<td>";
                    html += dataJson[i]["Tên hàng"];
                    html += "</td>";
                    html += "<td>";
                    html += dataJson[i]["Giá"].toLocaleString();
                    html += "</td>";
                    html += "<td>";
                    html += dataJson[i]["SL"];
                    html += "</td>";
                    html += "<td class='text-center'>";
                    html += '<button type="button" class="btn btn-success" onclick="GetitemID(\'' + dataJson[i]["ITEM_ID"] + '\',\'' + dataJson[i]["Tên hàng"] + '\')" data-toggle="modal" data-target="#myModal"> Diễn giải </button> ';
                    html += "</td>";
                    html += "<td class='text-center'>";
                    //  html += "<button type='button' onclick='DeleteItemID(\"" + dataJson[i]["ITEM_ID"] + "\",\"" + dataJson[i]["SL"] + "\")' id='" + dataJson[i]["ITEM_ID"] + "' class='btn btn-success btn_tra'>X</button>";
                    //html += "<button type='button' onclick='getinfo(\"" + dataJson[i]["STT"] + "\",\"" + dataJson[i]["ITEM_ID"] + "\",\"" + dataJson[i]["SL"] + "\",\"" + dataJson[i]["Tên hàng"] + "\"),loaibanphim=2' value='" + dataJson[i]["SL"] + "' id='" + dataJson[i]["ITEM_ID"] + "'  class='btn btn-success btn_tra' data-toggle='modal' data-target='#ModalBanPhimSo'>X</button>";
                    html += "<button type='button' onclick='DeleteItemID(\"" + dataJson[i]["STT"] + "\",\"" + dataJson[i]["ITEM_ID"] + "\",\"" + dataJson[i]["SL"] + "\",\"" + dataJson[i]["Giá"] + "\"),loaibanphim=2' id='" + dataJson[i]["ITEM_ID"] + "' class='btn btn-success btn_tra'>X</button>";
                    html += "</td>";
                    html += "</tr>";
                }

                $("#ItemOrder").html(html);
            } catch (ex) {
                alert(data);
            }
        }

        function InsertMonmo() {
            var print = "0";
            var tableid = "0";
            print = $('input[name="PrintName"]:checked', '#radCheck').val();
            var queryString = [];
            var hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                queryString.push(hash[1]);
            }
            
            tableid = queryString;

            $.ajax({
                type: "POST",
                url: "frm_Sale.aspx/InsertMonmo",
                data: "{itemname:'" + $('#txtTenmon').val() + "',price:'" + $('#txtDongia').val() + "',sl:'" + $('#txtSL').val() + "',Printer:'" + $("#Mayin option:selected").val() + "',Print:'" + print + "',tableidjq:'" + tableid + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "text",
                success: function(data) {
                    dienDuLieuVaoGrid(data);
                    hienThiGiaTienTrongGrid();

                    hienThiThongTinSales();

                    refreshQty();
                }
            });
        }

        function DeleteItemID(stt, itemid, slhientai, gia) {
            if (itemid == "899") {
                alert("KARAOKE KHÔNG ĐƯỢC TRẢ HÀNG! VUI LÒNG KHÔNG CHỌN ");
                return false;
            }
            var tableid = "0";
            var queryString = [];
            var hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                queryString.push(hash[1]);
            }
            if (slhientai > 0) {
                slhientai = slhientai.replace(".", ",");
            }

            if (parseFloat(qty) > parseFloat(slhientai)) {
                alert("Vui lòng kiểm tra lại số lượng trả hàng (" + qty + ") lớn hơn số lượng hiện tại (" + slhientai + ")");
                qty = 1;
            }
            else {
                tableid = queryString;
                $.ajax({
                    type: "POST",
                    url: "frm_Sale.aspx/DeleteItemOrder",
                    data: "{stt: '" + stt + "', itemid:'" + itemid + "',sltra:'" + qty + "',slhientai:'" + slhientai + "',gia:'" + gia + "',tableidjq:'" + tableid + "'}",
                    contentType: "application/json; charset=utf-8",
                    async: true,
                    cache: true,
                    dataType: "text",
                    success: function(data) {
                        dienDuLieuVaoGrid(data);
                        hienThiGiaTienTrongGrid();
                        qty = 1;
                    }
                });
            }
        }

        
        function DeleteAll(All) {
            var tableid = "0";
            var queryString = [];
            var hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                queryString.push(hash[1]);
            }

            tableid = queryString;
            
            $.ajax({
                type: "POST",
                url: "frm_Sale.aspx/DeleteAll",
                data: "{All:'" + tableid + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "text",
                success: function(data) {
                    document.getElementById('<%=btnRefresh.ClientID%>').click();
                }
            });
        }

        function refreshQty() {
            chuoi = "";
            qty = 1;
            // thiet lap active
            $(".classqty").removeClass("active_item");
            $("#qty_refresh").addClass("active_item");
        }
       
        function GetQty(sl) {
            chuoi = chuoi + sl;
            qty = chuoi;


            // thiet lap active
            $(".classqty").removeClass("active_item");
            if (sl == ".") {
                $("#qty_dot").addClass("active_item");
            } else {
                $("#qty_" + sl).addClass("active_item");
            }
        }
        var delete_itemid = "";
        var delete_qty = "";
        var slhientai = 0;
        function getinfo(STT,itemid, slhientai, tenmathang) {
            // alert(tenmathang);
            $("#telNumber").val(1);
            $("#txtMahangchon").val(itemid);
            $("#txtslht").val(slhientai);
            $("#lblTenmon").text(tenmathang);
            delete_itemid = itemid;
            delete_qty = qty;
            //alert(delete_itemid+' '+delete_qty);
        }
        function GetitemID(itemid, itemname) {
            $('#txtItemID').val(itemid);
            $('#lblItemName').text(itemname);

            var sohod = $('#txtSoHD').val();
            $.ajax({
                type: "POST",
                url: "frm_Sale.aspx/GetInfoDiengiai",
                data: "{itemid: '" + itemid + "', sohod:'" + sohod + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "text",
                success: function(data) {
                    try {
                        // alert(JSON.parse(data).d);
                        $('#txtDescription').val(JSON.parse(data).d);
                    } catch (ex) { }
                }
            });
        }
        
        function InsertDescription(itemid, descriptipon) {
            var tableid = "0";
            var queryString = [];
            var hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                queryString.push(hash[1]);
            }

            tableid = queryString;
            
            $.ajax({
                type: "POST",
                url: "frm_Sale.aspx/InsertDescription",
                data: "{itemid:'" + itemid + "',descriptipon:'" + descriptipon + "',tableid:'" + tableid + "'}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "json",
                success: function(msg) {
                    
                }
            });
        }
    </script>

</head>
<body>
    <form id="form1" runat="server" role="form">

        <script type="text/javascript">
//            Sys.Application.add_load(AppInit);

            function AppInit() {
                loadArare();            
            }

            function End(sender, args) {
                loadArare();
            }
            function loadArare() {
                $('.flexslider').flexslider({
                    animation: "slide",
                    animationLoop: false,
                    itemWidth: 105,
                    itemMargin: 5,
                    prevText: "",
                    nextText: "",
                    slideshow: false,
                    start: function(slider) {
                        $('body').removeClass('loading');
                    }
                });

                $("#Grouphdt_" + groupid).addClass("active");

                $("#manhomhanghoa_" + groupid).addClass("active");

                if (groupid != "01") {
                    $('#Grouphdt_01').removeClass('active');
                    $('#manhomhanghoa_01').removeClass('active');
                }
            }
        </script>
    
        <div class="container-fluid">
            <header id="header" class="row">
               <input id="txtslht" style="display: none;" />
                <div class="form-inline text-left header_form">
                    <div class="form-group none_mobile">
                        <label>SỐ HĐ </label>
                        <asp:TextBox ID="txtSoHD" runat="server" CssClass="textboxAbc" Text=""></asp:TextBox>
                    
                    </div>
                    <div class="form-group">
                        <label>BÀN</label>
                    
                        <asp:TextBox ID="txtTable" CssClass="textboxAbc" runat="server" Text=""></asp:TextBox>
                    </div>
                    <div class="form-group none_mobile">
                        <label>NHÂN VIÊN</label>
                        <asp:TextBox ID="txtNhanVien" CssClass="textboxAbc" runat="server" Text=""></asp:TextBox>
                  
                    </div>
                </div>

            </header>
                <!-- end #header -->
             <div id="content" class="row content_order">
                <div class="wrap_menu_tab">
                <div class="flexslider wrap_flexslider">
                    <ul class="nav nav-tabs menu_tab menu_tab_bb slides" role="tablist">
                        <%Dim activemenugroup As String = ""%>
                        <%For index As Integer = 0 To mvObj_GroupItemData.Rows.Count - 1%>
                        <%
                                If index = 0 Then
                                    activemenugroup = "active"
                                Else
                                    activemenugroup = ""
                                End If
                        %>
                        <li class="<%=activemenugroup %>" id="#manhomhanghoa_<%=mvObj_GroupItemData.Rows(index).Item("id")%>">
                            <a href="#manhomhanghoa_<%=mvObj_GroupItemData.Rows(index).Item("id")%>" role="tab"
                                data-toggle="tab">
                                <%=mvObj_GroupItemData.Rows(index).Item("Name")%>
                            </a></li>
                        <% Next%>
                        <div class="clearfix">
                        </div>
                    </ul>
                </div>
            </div>
                <div class="col-md-7 wrap_col_ttt">
                    <div class="wrap_menu_tab wrap_menu_tab_ttt">
                        <!-- Nav tabs -->
                      
                        <!-- Tab panes -->
                        <%Dim activeitem As String = ""%>
                        <div id="content_tt" class="tab-content tab_content_menu tab_content_menu_ttt">
                            <%For rowkv As Integer = 0 To mvObj_GroupItemData.Rows.Count - 1%>
                            <%
                                If rowkv = 0 Then
                                    activeitem = "active"
                                Else
                                    activeitem = ""
                                End If
                            %>
                            <div class="tab-pane <%=activeitem %>" id="manhomhanghoa_<%= mvObj_GroupItemData.Rows(rowkv).Item("id")%>">
                                <%  
                                    Dim mvObj_TableData_Sale As System.Data.DataTable = New System.Data.DataTable
                                    mvCls_ItemUpdate = New cls_Item_Update
                                    mvObj_TableData_Sale = mvCls_ItemUpdate.FuncG_GetAllData123(mvObj_GroupItemData.Rows(rowkv).Item("id"))
                                %>
                                <ul class="list-inline tab_content_table tab_content_table_order">
                                <%Dim active2 As String = ""%>
                                <%For rowtb As Integer = 0 To mvObj_TableData_Sale.Rows.Count - 1%>
                                <li>
                                    <%
                                        Dim i As Integer = mvObj_TableData_Sale.Rows(rowtb).Item("Color")
                                        Dim mausac As Color = Color.FromArgb(i)
                                        Dim strColor As String = System.Drawing.ColorTranslator.ToHtml(mausac)
                                        %>
                                    <% If mvObj_TableData_Sale.Rows(rowtb).Item("PRICE1").ToString() <> "0" Then%>
                                    <button class="btn_item hienthimaugia" style="background:<%=strColor%> "  type="button" onclick="InsertItemID('<%=mvObj_TableData_Sale.Rows(rowtb).Item("id")%>')"
                                        id="btn_<%=mvObj_TableData_Sale.Rows(rowtb).Item("id")%>">
                                        <%=mvObj_TableData_Sale.Rows(rowtb).Item("Name")%>
                                    </button>
                                    <% Else%>
                                    <button class="btn_item hienthimaugiakhong" type="button" style="background:<%=strColor%> " onclick="InsertItemID('<%=mvObj_TableData_Sale.Rows(rowtb).Item("id")%>')"
                                        id="btn_<%=mvObj_TableData_Sale.Rows(rowtb).Item("id")%>">
                                        <%=mvObj_TableData_Sale.Rows(rowtb).Item("Name")%>
                                    </button>
                                    <% End If%>
                                </li>
                                <% Next%>
                            </ul>
                            </div>
                            <% Next%>
                        </div>
                        <div class="clearfix">
                        </div>
                    </div>
                    <!-- end .wrap_menu_tab -->
					     <ul class="list-inline order_nhanh_select text-center">
                    <li>
                        <input class="classqty" id="qty_1" data-toggle='modal'  type="button" value="1"></li>
                    <li>
                        <input class="classqty" id="qty_2" onclick="GetQty('2')" type="button" value="2"></li>
                    <li>
                        <input class="classqty" id="qty_3" onclick="GetQty('3')" type="button" value="3"></li>
                    <li>
                        <input class="classqty" id="qty_4" onclick="GetQty('4')" type="button" value="4"></li>
                    <li>
                        <input class="classqty" id="qty_5" onclick="GetQty('5')" type="button" value="5"></li>
                    <li>
                        <input class="classqty" id="qty_6" onclick="GetQty('6')" type="button" value="6"></li>
                    <li>
                        <input class="classqty" id="qty_7" onclick="GetQty('7')" type="button" value="7"></li>
                    <li>
                        <input class="classqty" id="qty_8" onclick="GetQty('8')" type="button" value="8"></li>
                    <li>
                        <input class="classqty" id="qty_9" onclick="GetQty('9')" type="button" value="9"></li>
                    <li>
                        <input class="classqty" id="qty_0" onclick="GetQty('0')" type="button" value="0"></li>
                    <li>
                        <input class="classqty" id="qty_dot" onclick="GetQty('.')" type="button" value="."></li>
                    <li>
                        <input class="classqty" id="qty_refresh" onclick="refreshQty()" type="button" value="CE"></li>
                </ul>
                    <div id="action_btn">
                        <ul class="list-inline action_btn_ul">
                            <li>
                                <asp:Button ID="btnSenOder"  runat="server" Text="Send" CssClass="action_btn_ul_inbut action_btn_ul_inbut4" /></li>
                            <li>
                                <asp:Button ID="btnTinhtien" runat="server" Text="Tính tiền" CssClass="action_btn_ul_inbut action_btn_ul_inbut24" />
                                </li>
                                
                                <li style="display:none;">
                                <asp:Button ID="btnTinhtienKin" runat="server" Text="Không In" CssClass="action_btn_ul_inbut action_btn_ul_inbut24" />
                                </li>
                            <li style="display:none;">
                                <asp:Button ID="btnDel" OnClientClick="DeleteAll('All');" runat="server" Text="Xóa"
                                    CssClass="action_btn_ul_inbut action_btn_ul_inbut_del" /></li>
                            <li >
                            <button type="button"  class="action_btn_ul_inbut action_btn_ul_inbut6" data-toggle="modal" data-target="#myModal2">
                                Món mở
                            </button>
                                <%--<asp:Button ID="btnMonMo"  runat="server" Text="Món mở" CssClass="action_btn_ul_inbut action_btn_ul_inbut6"  data-toggle="modal" data-target="#myModal"/></li>--%>
                            <li>
                                <asp:Button ID="btnThoat" runat="server" Text="Thoát" CssClass="action_btn_ul_inbut action_btn_ul_inbut4" />
                            </li>
                        </ul>
                    </div>
                    <!-- end #action_btn -->
                </div>
                <div class="col-md-5 wrap_table_order">
                    <table class="table table-bordered table-responsive table_order">
                        <thead>
                            <tr class="table_order_th">
                                <th width="60%">
                                    TÊN HÀNG
                                </th>
                                <th width="20%">
                                    GIÁ
                                </th>
                                <th width="10%">
                                   SL
                                </th>
                               
                                <th width="20%">
                                    Diễn giải
                                </th>
                             
                                <th width="10%">
                                    Action
                                </th>
                            </tr>
                        </thead>
                        <tbody id="ItemOrder">
                        </tbody>
                        <div class="modal fade" id="myModal" data-backdrop="static" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
                                            aria-hidden="true">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal">
                                            <span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                                        <h4 class="modal-title" id="H1">
                                            <label id="lblItemName"></label></h4>
                                    </div>
                                    <div class="modal-body">
                                        <textarea class="form-control" id="txtDescription" ></textarea>
                                        <input id="txtItemID" style="display: none;" />
                                    </div>
                                    <div class="modal-footer" style="  text-align: center;>
                                        <button type="button" style="display:none;" class="btn btn-default" data-dismiss="modal">
                                            </button>
                                        
                                        <button style="  height: 50px; width: 110px;" type="button" id="btnSave" onclick="InsertDescription($('#txtItemID').val(),$('#txtDescription').val())"
                                            data-dismiss="modal" class="btn btn-success">
                                            Lưu</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </table>
                    
                    <table class="table table-bordered table-responsive table_order" >                            
                        <tr class="table_order_th" style="font-size: 12px;">
                            <th style="text-align:center;" width="20%">
                                TỔNG CỘNG
                            </th>
                            <th style="text-align:center;" width="20%">
                               GIẢM GIÁ
                            </th>
                            <th style="text-align:center;" width="20%">
                             PHÍ PHỤC VỤ
                            </th>
                                   
                            <th style="text-align:center;" width="20%">
                                VAT
                            </th>
                             
                            <th style="text-align:center;" width="20%">
                                THÀNH TIỀN
                            </th>
                        </tr>
                        <tr class="table_order_th" style="font-size: 12px;">
                            <th style="text-align:right;" width="20%" id="thTongCong">
                                <%--<%=Convert.ToDouble(dtTotal.Rows(0)("TOTAL")).ToString("#,##")%>--%>
                            </th>
                            <th  style="text-align:right;" width="20%" id="thGiamGia">
                               <%--<%=Convert.ToDouble(dtTotal.Rows(0)("DISCOUNT")).ToString("#,##")%>--%>
                            </th>
                            <th width="20%" style="text-align:right;" id="thPhiDichVu">
                             <%--<%=Convert.ToDouble(dtTotal.Rows(0)("SERVICE")).ToString("#,##")%>--%>
                            </th>
                           
                            <th width="20%" style="text-align:right;" id="thVAT">
                                <%--<%=Convert.ToDouble(dtTotal.Rows(0)("VAT")).ToString("#,##")%>--%>
                            </th>
                         
                            <th width="20%" style="text-align:right;" id="thThanhTien">
                                <%--<%=Convert.ToDouble(dtTotal.Rows(0)("TOTALCOST")).ToString("#,##")%>--%>
                            </th>
                        </tr>
                    </table>
                </div>
            </div>
            <!-- end #content -->
        </div>
        
        <div style="display: none">
            <input id="txtgroupactive" />
            <asp:Button ID="btnRefresh" runat="server" Text="Button" />
        </div>
	
	    <!-- Modal -->
	    <div class="modal fade modal_custom" id="myModal2" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
		    <div class="modal-dialog">
			    <div class="modal-content">
				<div class="modal-header">
					<button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
					<h4 class="modal-title" id="myModalLabel">Cài đặt món mở</h4>
				</div>
				<div class="modal-body">
					<div class="form-horizontal">
						<div class="form-group">
							<label class="col-sm-3 control-label">Tên mặt hàng</label>
							<div class="col-sm-9">
								<input type="text" id="txtTenmon" style="text-transform: uppercase;" class="form-control">
							</div>
						</div>
						<div class="form-group">
							<label class="col-sm-3 control-label">Số Lượng</label>
							<div class="col-sm-9">
								<input type="text" id="txtSL" value="1"  class="form-control" >
							</div>
						</div>
						<div class="form-group">
							<label class="col-sm-3 control-label">Đơn giá</label>
							<div class="col-sm-9">
								<input type="text" id="txtDongia" value="0" class="form-control" >
							</div>
						</div>
						<div class="form-group">
							<label class="col-sm-3 control-label">Máy in</label>
							<div class="col-sm-9">
								<%--<select id="Mayin" class="form-control">
									<option value="01">BEP1</option>
									<option value="02">BAR</option>
									<option value="03">BEP2</option>									
								</select>--%>
                                <asp:DropDownList  ID="Mayin" runat="server" class="form-control">
                                </asp:DropDownList>
							</div>
						</div>
						<div class="form-group">
							<label class="col-sm-3 control-label"></label>
							<div class="col-sm-9" id="radCheck">
								<label class="radio-inline">
									<input type="radio" name="PrintName" id="inlineRadio2" value="1"> In
								</label>
								<label class="radio-inline">
									<input type="radio" name="PrintName" id="inlineRadio3" checked="checked" value="0"> Không In
								</label>
							</div>
							
						</div>
					</div>
				</div>
				<div class="modal-footer">
					<button type="button" class="btn btn-default" data-dismiss="modal">Đóng</button>
					<button type="button" onclick="InsertMonmo();" data-dismiss="modal" class="btn btn-primary">Lưu</button>
				</div>
			</div>
		    </div>
	    </div>
	    <!-- End Modal -->
	 <%--============================ BAN PHIM SO ===================================--%>
    <link href="css/banphimso.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript">
         // ban phim so

         $(document).ready(function() {
             $("#telNumber").val(1);
             $('.num').click(function() {
                 var num = $(this);
                 var text = $.trim(num.find('.txt').clone().children().remove().end().text());
                 var telNumber = $('#telNumber');
                 $(telNumber).val(telNumber.val() + text);
             });
             $('.txtXoa').click(function() {
                 var telNumber = $('#telNumber').val();
                 telNumber = telNumber.substring(0, telNumber.length - 1);
                 $("#telNumber").val(telNumber);

             });

         });
         function GetItemIDBPS(itemID, tenmon) {
             $("#telNumber").val(1);
             $("#txtMahangchon").val(itemID);

             $("#lblTenmon").text(tenmon);
         }
         function inserttubanphim(itemID, soluong, loai) {
             //loai =1 insert
             // loai =2 delete
             slhientai = $("#txtslht").val();

             qty = soluong;
            // alert("Mon:" + itemID + "soluong:" + soluong + "Loại :" + loai);
             if (loai == 1) {

                 if (soluong > 0) {
                     if (soluong < 1000) {
                         InsertItemID(itemID, soluong);
                     }
                     else
                         alert("Vui lòng nhập số lượng nhỏ hơn 1000");
                 }
                 else {
                     alert("Vui lòng nhập số lượng");
                 }
             }
             else if (loai = 2) {
                 if (soluong > 0) {
                     DeleteItemID(itemID, slhientai);
                 }
             }
         }
         $("input#Payment").keypress(function(e) {
             if (e.keyCode == 9) {
                 $("input#txtItemID").focus();
             }
         });
     </script>
      <div id="ModalBanPhimSo" class="container modal fade modal_custom">
         <div class="row">
        <div class="col-md-4 col-md-offset-4 phone">
            <div class="row1">
                <div class="col-md-12">
                 <h4 style="    text-align: center;color: red;">
                 <label style="FONT-SIZE: 14px;" id="lblTenmon"></label>
                 </h4>
                 <input type="tel" name="name" id="txtMahangchon" style="display:none;" class="form-control tel" disabled value="" />
                <input type="tel" name="name" id="telNumber" class="form-control tel" disabled value="" />
               
                    <div class="num-pad">
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                1
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                2
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                3
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                4
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                              5
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                6 
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                7 
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                8
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                9
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                .
                            </div>
                        </div>
                    </div>
                    <div class="span4">
                        <div class="num">
                            <div class="txt">
                                0 
                            </div>
                        </div>
                    </div>
                  <div class="span4">
                        <div class="num">
                            <div class="txtXoa">
                               XÓA 
                            </div>
                        </div>
                    </div>
                     <br />
                    </div>
                   
                    <div class="clearfix">
                    
                    </div>
                        <input type="button" value="XÁC NHẬN" onclick="inserttubanphim($('#txtMahangchon').val(),$('#telNumber').val(),loaibanphim);"  data-dismiss="modal" class="btn btn-success btn-block flatbtn" />
                        <input type="button" value="HỦY" class="btn btn-success btn-block flatbtn" data-dismiss="modal" />
                        <br />
                </div>
            </div>
            <div class="clearfix">
            </div>
        </div>
    </div>
      </div>
 <%--============================ END ===================================--%>
    </form>
	
</body>
</html>
