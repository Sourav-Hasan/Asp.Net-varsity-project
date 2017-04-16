<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Workshop.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login Form</title>
    <link href="StyleSheet_login.css" rel="stylesheet" />
</head>
<body>
     <div align="center" style="border:5px solid black " >
        <h1 style="color:#FF0000";>
    <a href="HomePage.html" style="text-decoration:none">Home</a>&nbsp;&nbsp;&nbsp;&nbsp;
    <a href="Patient_list.aspx" style="text-decoration:none">Existing Patient</a>&nbsp;&nbsp;&nbsp;&nbsp;
    <a href="DoctorList.aspx" style="text-decoration:none">Available Doctor</a>
        </h1>
    </div>
    <form id="form1" runat="server">
    <div class="fullpage">
        <div class="login">
            <table style="width: 100%;">
                <tr><h1 style="text-align:center">Log In</h1></tr>
                <tr>
                    <td style="padding:18px; color:#fff;">
                        User Name :
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td style="padding:18px;color:#fff;">
                        Password:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_pass" TextMode="Password" runat="server"></asp:TextBox>
                        
                    </td>
                    
                </tr>
                    
            </table>
            <div class="button">
                 <asp:Button ID="Button1" class="button1" runat="server" Text="Cancel" Width="50px" OnClick="Button1_Click" />
                 &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button_login" class="button2" runat="server" Text="Login" Width="50px" OnClick="Button_login_Click" />
            </div>
            <br />
            <div class="label">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </div>
          
        </div>
    </div> 
        <%--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >Home</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Existing Patient</asp:LinkButton>
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Avaiable Doctor</asp:LinkButton>--%>
    </form>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
   
</body>
</html>
