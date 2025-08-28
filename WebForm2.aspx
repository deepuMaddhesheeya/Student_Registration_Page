<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Student_Registration.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .auto-style1 {
            height: 55px;
        }
    </style>
</head>
<body style="background-color:coral;">
    <form id="form1" runat="server">
     <table runat="server"  style="margin-left:40%;margin-top:15%;background-color:aqua;height:200px;width:200px">
         <tr >
             <td style="padding-left:35%"><strong><asp:Label ID="Label1" runat="server" Text="Login"></asp:Label></strong></td>
         </tr>
         <tr>
             <td class="auto-style1"><asp:TextBox ID="TextBox1" runat="server" PlaceHolder="Username" Height="23px" Width="195px"></asp:TextBox></td>
         </tr>
         <tr>
             <td><asp:TextBox ID="TextBox2" runat="server" PlaceHolder="Password" Height="23px" Width="162px" TextMode="Password" ></asp:TextBox>
                 <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Properties/icon-eye.png" Height="23px" Width="22px" OnClick="ImageButton1_Click"  />
             </td>
         
         </tr>
         <tr>
             <td style="padding-left:35%"><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" BackColor="#33CC33" /></td>
         </tr>
     </table>
    </form>
</body>
</html>
