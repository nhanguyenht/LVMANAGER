<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_Main.aspx.vb" Inherits="frm_Main" %>

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
  <script>
      window.sessionStorage.setItem("kvid",null);
//  $(document).ready(function(){
//  //window.open("https://www.google.com.vn/", "name", "top=0,left=0,width=" + window.screen.width + ",height=" + window.screen.height);
//  window.scrollTo(0, 1);
      //  })
      function hideAddressBar() {
          if (!window.location.hash) {
              if (document.height < window.outerHeight) {
                  document.body.style.height = (window.outerHeight + 50) + 'px';
              }

              setTimeout(function() { window.scrollTo(0, 1); }, 50);
          }
      }
      window.addEventListener("load", function() { if (!window.pageYOffset) { hideAddressBar(); } });
      window.addEventListener("orientationchange", hideAddressBar);
  </script>
</head>
<body >
 <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <Triggers></Triggers>
  <ContentTemplate>
    <div class="container-fluid">
        <header id="header">
      <h4>Khách hàng của chúng tôi</h4>
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">

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
        <div id="content" style="margin-top:30px;">
          
            <!-- end .wrap_menu_tab -->
            <div id="action_btn">
                 <div class="list-inline text-center banhang_uu">
                 <p >
                
                  <asp:Button ID="btnBanhang" runat="server" Text="BÁN HÀNG" CssClass="btn btn-success btn-lg btn-block btn_main" />
              
      </p>
            <p >
                <%  If (gvStr_Permit = "11111111") Then %>
                         <asp:Button ID="btnBaoCaoBanHang" runat="server" Text="BÁO CÁO BÁN HÀNG" CssClass="btn btn-success btn-lg btn-block btn_main" />
                   <% End If%>
              
              
          
            </p>
            <p>
           
              
              <asp:Button ID="btnThoat" runat="server" Text="Thoát" CssClass="btn btn-danger btn-lg btn-block btn_main" />
            
            </p>
          </div>
            </div>
            <!-- end #action_btn -->
        </div>
        <!-- end #content -->
    </div>
    </ContentTemplate>
      </asp:UpdatePanel>
    <!-- end .container-fluid -->
    </form>
</body>
</html>
