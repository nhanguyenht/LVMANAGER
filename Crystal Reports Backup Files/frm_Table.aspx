<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_Table.aspx.vb" Inherits="FrmArea" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <%--<meta http-equiv="refresh" content="1">--%>
    <title>Khu Vực Bàn</title>
    <link href="css/bootstrap-3.2.0.min.css" rel="stylesheet">
    <%--<link href='http://fonts.googleapis.com/css?family=Open+Sans&subset=vietnamese' rel='stylesheet'
        type='text/css'>--%>
    <link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <script src="js/jquery-1.11.1.min.js"></script>

    <script src="js/bootstrap-3.2.0.min.js"></script>
	<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />
	<link href="css/style.css" rel="stylesheet">
	
	<!-- FlexSlider -->
  <script defer src="js/jquery.flexslider.js"></script>

   <script type="text/javascript">
       var groupid = "01";

       $(window).load(function() {
       var mkv = window.sessionStorage.getItem("kvid");
        
           if (mkv == "null" ||mkv==null) {
               groupid = "01"
           }
           else {
               groupid = mkv;
           }

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

           $("#makhuvucLI_" + groupid).addClass("active");
           $("#makhuvuc_" + groupid).addClass("active");
           if (groupid != "01") {

               $('#makhuvucLI_01').removeClass('active');
               $('#makhuvuc_01').removeClass('active');

           }
       });
     
       function setKvclick(makv) {
           window.sessionStorage.setItem("kvid", makv);
       }
  </script>

	
    <script type="text/javascript">
        var ban1 = '';
        var ban2 = '';
        var act = '';
        var val1 = '';
        var val2 = '';

        // chuyen trang tuong ung voi cac tac vu
        function gettableid(tableid, val) {
            var _url = '';

            switch (val) {
                case "active":
                    break;
                default: val = '';
                    break
            }

            switch (act) {
                case "chia":
                    _url = "frm_Split.aspx";
                    if (ban1 == '') {
                        ban1 = tableid;
                        val1 = val;
                        return;
                    }
                    if (ban2 == '') {
                        ban2 = tableid;
                        val2 = val;
                    }
                    if (val1 == 'active') { if (val2 == 'active') { alert("Bàn chia không hợp lệ"); resetpar(); return; } }
                    else { alert("Bàn chia không hợp lệ"); resetpar(); return; }
                    break;
                case "chuyen":
                    _url = "frm_Transfer.aspx";
                    if (ban1 == '') {
                        ban1 = tableid;
                        val1 = val;
                        return;
                    }
                    if (ban2 == '') {
                        ban2 = tableid;
                        val2 = val;
                    }
                    if (val1 == 'active') {
                        if (val2 == 'active') {
                            alert("Bàn chuyển đến không hợp lệ"); resetpar(); return;
                        }
                    }
                    else { alert("Bàn chuyển đi không hợp lệ"); resetpar(); return; }
                    break;
                case "gop":
                    _url = "frm_Combined.aspx";
                    if (ban1 == '') {
                        ban1 = tableid;
                        val1 = val;
                        return;
                    }
                    if (ban2 == '') {
                        ban2 = tableid;
                        val2 = val;
                    }
                    if (val1 != 'active') { alert("Bàn gộp không hợp lệ"); resetpar(); return; }
                    else
                    { if (val2 != 'active') { alert("Bàn gộp không hợp lệ"); resetpar(); return; } }
                    break;
                default: _url = "frm_Sale.aspx" + "?tableid=" + tableid;
                    break;
            }

            if (act == '')
                window.location.href = _url;

            if (act != '' && ban1 != '' && ban2 != '') {
                // alert("dsd");
//                //=============================
//                $.ajax({
//                    type: "POST",
//                    url: "frm_Table.aspx/SubM_TransferTable",
//                    data: "{Invoice:'" + 0 + "',SourceTableID:'" + ban1 + "',DestTableID:'" + ban2 + "'}",
//                    contentType: "application/json; charset=utf-8",
//                    async: true,
//                    cache: false,
//                    dataType: "text",
//                    success: function(data) {
//                        location.reload();
//                        resetpar();
//                    }
//                });
//                //===============================
                window.location.href = _url + "?fid=" + ban1 + "&tid=" + ban2;
                resetpar();
            }
        }

        // lay tac vu
        function getact(action) {
            act = action;
            switch (act) {
                case "chia":
                  //  alert("Chia bàn");
                    break;
                case "chuyen":
                   // alert("Chuyển bàn");
                    break;
                case "gop":
                    //alert("Gộp bàn");
                    break;
                default:
                    break;
            }
        }

        // reset tham so
        function resetpar() {
            act = ban1 = ban2 = val1 = val2 = '';
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <script type="text/javascript">
    
    
        Sys.Application.add_load(AppInit);

        function AppInit() {
            var mkv = window.sessionStorage.getItem("kvid");

            if (mkv == "null" || mkv == null) {
                groupid = "01"

            }
            else {
                groupid = mkv;
            }
            loadArare();

            $("#makhuvucLI_" + groupid).addClass("active");
            $("#makhuvuc_" + groupid).addClass("active");
            if (groupid != "01") {

                $('#makhuvucLI_01').removeClass('active');
                $('#makhuvuc_01').removeClass('active');

            }
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


        }
       
       
    </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <Triggers>
        <asp:AsyncPostBackTrigger  ControlID="Timer1" EventName="Tick" />
    </Triggers>
  <ContentTemplate>
    <div class="container-fluid">
        <header id="header">
     <%-- <h4>Khách hàng của chúng tôi</h4>--%>
    <div id="carousel-example-generic" style="display:none;" class="carousel slide" data-ride="carousel">

          <!-- Wrapper for slides -->
          <div class="carousel-inner" role="listbox">
          <div class="item item_slide_custom active">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/kh_01.png"></li>
                <li class="text-left item_slide2">
                  <p>HULA BEER CLUB</p>
                  <p>321A Phạm Văn Đồng, Phường 3, Quận Gò Vấp</p>
                </li>
              </ul>
            </div>
            <div class="item item_slide_custom">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/kh_02.png"></li>
                <li class="text-left item_slide2">
                  <p>MARINA COFFEE</p>
                  <p>Đường Phan Đình Phùng, TP. Châu Đốc, T. An Giang</p>
                </li>
              </ul>
            </div>
            <div class="item item_slide_custom">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/kh_03.png"></li>
                <li class="text-left item_slide2">
                  <p>TRẠM DỪNG CHÂN PHƯƠNG TRANG</p>
                  <p>QL.1A, Hòa Khánh, Cái Bè, Tiền Giang</p>
                </li>
              </ul>
            </div>
			<div class="item item_slide_custom">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/kh_04.png"></li>
                <li class="text-left item_slide2">
                  <p>BÚN BÒ HUẾ DA HỘI </p>
                  <p>230 Canley vale road Canley heights NSW 2166</p>
                </li>
              </ul>
            </div>
			<div class="item item_slide_custom">
              <ul class="list-inline">
                <li class="text-right item_slide1"><img src="images/kh_05.png"></li>
                <li class="text-left item_slide2">
                  <p>NHÀ HÀNG HẢI SẢN LÂM ĐƯỜNG</p>
                  <p>125B Trần phú, P. 5, TP. Vũng Tàu</p>
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
      </header><!-- end #header -->
        <!-- end #header -->
        <div id="content">
            <div class="wrap_menu_tab">
                <!-- Nav tabs -->
				<div class="flexslider wrap_flexslider">
					<ul class="nav nav-tabs menu_tab menu_tab_bb slides" role="tablist">
					   
						 <%Dim active As String = ""%>
						<%For index As Integer = 0 To mvObj_AreaData.Rows.Count - 1%>
							<%
								If index = 0 Then
									active = "active"
								Else
									active = ""
								End If
							%>
							<li class="<%=active %>" id="makhuvucLI_<%=mvObj_AreaData.Rows(index).Item("id")%>" >
								<a onclick="setKvclick('<%=mvObj_AreaData.Rows(index).Item("id")%>')"   href="#makhuvuc_<%=mvObj_AreaData.Rows(index).Item("id")%>" role="tab" data-toggle="tab">
									<span><%=mvObj_AreaData.Rows(index).Item("Name")%></span>
								</a>
							</li>
						   
						<% Next%>
						<div class="clearfix"></div>
					</ul>
				</div>
                <!-- Tab panes -->
                 <%Dim active1 As String = ""%>
                <div class="tab-content tab_content_menu" style="height:auto !important;">
                    <%For rowkv As Integer = 0 To mvObj_AreaData.Rows.Count - 1%>
                     <%
                         If rowkv = 0 Then
                             active1 = "active"
                         Else
                             active1 = ""
                         End If
 %>
                        <div class="tab-pane <%=active1 %>" id="makhuvuc_<%= mvObj_AreaData.Rows(rowkv).Item("id")%>">
                                <%  Dim mvObj_TableData_Menugroup As System.Data.DataTable = New System.Data.DataTable
                                    mvCls_TableUpdate = New cls_Table_Update
                                    mvObj_TableData_Menugroup = mvCls_TableUpdate.FuncG_GetData(mvObj_AreaData.Rows(rowkv).Item("id"))
                                %>
                                 <ul class="list-inline tab_content_table">
                                 <%Dim active2 As String = ""%>
                                <%For rowtb As Integer = 0 To mvObj_TableData_Menugroup.Rows.Count - 1%>
                                   <%  If mvObj_TableData_Menugroup.Rows(rowtb).Item("STATUS") = 2 Then
                                           active2 = "active"
                                       ElseIf mvObj_TableData_Menugroup.Rows(rowtb).Item("STATUS") = 3 Then
                                           active2 = "activered"
                                       Else
                                           active2 = ""
                                       End If
                                       %>
                                        <li class='<%=active2 %>'>
                                        
                                        <button type="button" value="<%=active2 %>" onclick="gettableid('<%=mvObj_TableData_Menugroup.Rows(rowtb).Item("id")%>','<%=active2 %>')" id="<%=mvObj_TableData_Menugroup.Rows(rowtb).Item("id")%>"  >
                                        <%=mvObj_TableData_Menugroup.Rows(rowtb).Item("Name")%> 
                                        
                                        </button>
                                            </li>
                                   
                                <% Next%>
                                 </ul>
                        </div>
                    <% Next%>
                </div>
            </div>
            <!-- end .wrap_menu_tab -->
            <div id="action_btn">
                 <ul class="list-inline action_btn_ul">
            <li>
              
              <button type="button" onclick="getact('chia')" class="action_btn_ul_inbut action_btn_ul_inbut1 btn-success">Chia bàn</button>
            </li>
            <li>
             
              <button type="button" onclick="getact('gop')" class="action_btn_ul_inbut action_btn_ul_inbut2 btn-success">Gộp bàn</button>
            </li>
          
            <li>
             
              <button type="button" onclick="getact('chuyen')" class="action_btn_ul_inbut action_btn_ul_inbut3 btn-success">Chuyển bàn</button>
            </li>
            <li>
                         <asp:Button ID="btnThoat" runat="server" Text="Thoát" CssClass="action_btn_ul_inbut action_btn_ul_inbut4 btn-danger" />
            </li>
          </ul>
            </div>
            <!-- end #action_btn -->
        </div>
        <!-- end #content -->
    </div>
    </ContentTemplate>
      </asp:UpdatePanel>
       <asp:Timer ID="Timer1" runat="server"  Interval="10000" OnTick="Timer1_Tick">
</asp:Timer> 
    <!-- end .container-fluid -->
    </form>
</body>
</html>
