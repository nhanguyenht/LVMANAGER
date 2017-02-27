<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>BÁN HÀNG</title>
  <link href="images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="css/bootstrap-3.2.0.min.css" rel="stylesheet">
    <%--<link href='http://fonts.googleapis.com/css?family=Open+Sans&subset=vietnamese' rel='stylesheet' type='text/css'>--%>
    <link href="css/style.css" rel="stylesheet">



	 <script src="js/jquery-1.11.1.min.js"></script>
    <script src="js/bootstrap-3.2.0.min.js"></script>
     <script type="text/javascript">
         navigator.standalone = navigator.standalone || (screen.height - document.documentElement.clientHeight < 40)
     </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
    <div class="container-fluid wrap_box_login">
      <!--<a href="#"><img class="logo_login" src="images/logo.png"></a>-->
      <h3 class="h3_login">
        <p>Chào mừng bạn đến với phần mềm order trên Ipad của</p> 
        <p>CÔNG TY CỔ PHẦN CÔNG NGHỆ SỐ LÊ VŨ</p>
        </h3>
      <div class="box_login">
        <div class="img_login"><img src="images/logo.png"></div>
        <form role="form">
          <div class="form-group">
            <label for="exampleInputEmail1">Tên đăng nhập</label>
             <asp:TextBox ID="txtUserName" runat="server" placeholder="Nhập tên đăng nhập" CssClass="form-control"></asp:TextBox>
            
          </div>
          <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
            
             <asp:TextBox ID="txtPassword"  runat="server" placeholder="Nhập mật khẩu" 
                  CssClass="form-control" TextMode="Password"></asp:TextBox>
          </div>
          <div style="color:Red;">
           <asp:Label ID="lblThongbao" runat="server"></asp:Label>
          </div>
          <div class="checkbox">
            <label>
              <input type="checkbox"> Nhớ mật khẩu
            </label>
          </div>
          <div class="login_btn_wrap">
        
         
             <asp:Button type="submit" id="btnLogin" runat="server" Text="Đăng Nhập" class="btn btn-default box_login_btn ">
             
            </asp:Button>
          </div>
        </form>
      </div>
    </div>
    </div>
    </form>
   
</body>

</html>
