<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Student_Registration.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style type="text/css">

        .auto-style1 {
            font-size: x-large;
            padding-top:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
            <asp:Image ID="Image1" runat="server" Height="51px" Width="59px" ImageUrl="~/Properties/Universal_public_school.jpeg" />
             <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Universal Public School" style="padding-left:5%"></asp:Label>

          <b><p style="padding-left:17%">Admission Form</p> </b>
               
            <p>Perticulars of student(IN BLOCK LETTERS)</p>
              

        <table border="1">

            <tr>
                 <td>
                       <asp:Label ID="Label2" runat="server" Text="Enroll no"></asp:Label>
                </td>
                <td>
                       <asp:TextBox ID="TextBox1" runat="server" PlaceHolder="Enroll no" Height="23px" Width="195px"></asp:TextBox>
                </td>    
            </tr>
            <tr>
                  <td>
                      <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="TextBox2" runat="server" PlaceHolder="Name" Height="23px" Width="195px"></asp:TextBox>
                  </td>
                </tr>

            <tr><td>
        <asp:Label ID="Label4" runat="server" Text="Father's  Name"></asp:Label></td>
        <td> <asp:TextBox ID="TextBox3" runat="server" PlaceHolder="Father_Name" Height="23px" Width="195px"></asp:TextBox></td>
        </tr>
            <tr><td>
        <asp:Label ID="Label5" runat="server" Text="Mother's Name"></asp:Label></td>

<td>        <asp:TextBox ID="TextBox4" runat="server" PlaceHolder="Mother's Name" Height="23px" Width="195px"></asp:TextBox></td>
        </tr>
            <tr>
                  <td> <asp:Label ID="Label6" runat="server" Text="Aadhar Card No"></asp:Label></td>

                   <td><asp:TextBox ID="TextBox5" runat="server" PlaceHolder="Aadhar Card No" Height="23px" Width="195px"></asp:TextBox></td>
         </tr>
          <tr>
                   <td><asp:Label ID="Label7" runat="server" Text="Date of Birth" ></asp:Label></td>

                    <td><asp:TextBox ID="TextBox6" runat="server" Type="Date" PlaceHolder="D.O.B" Height="23px" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
                    <td><asp:Label ID="Label8" runat="server" Text="Date of Addmission" ></asp:Label></td>
        
                    <td><asp:TextBox ID="TextBox7" runat="server" Type="Date" PlaceHolder="D.O.A" Height="23px" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
                    <td><asp:Label ID="Label9" runat="server" Text="Place of Birth" ></asp:Label></td>
                    <td><asp:TextBox ID="TextBox8" runat="server"  PlaceHolder="Place of Birth" Height="23px" Width="195px"></asp:TextBox></td>
        </tr>
        <tr>
                     <td><asp:Label ID="Label10" runat="server" Text="Physical problem/Disability(If any)"></asp:Label></td>
                     <td><asp:TextBox ID="TextBox9" runat="server" PlaceHolder="Disability" Height="23px" Width="130px"></asp:TextBox></td>
        </tr>
        <tr>
                      <td><asp:Label ID="Label11" runat="server" Text="Caste"></asp:Label></td>
                       <td><asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem >General</asp:ListItem>
                            <asp:ListItem >OBC</asp:ListItem>
                            <asp:ListItem >SC</asp:ListItem>
                            <asp:ListItem >ST</asp:ListItem>
                            </asp:DropDownList>
                       </td>
        </tr>
          <tr>
                         <td>   <asp:Label ID="Label12" runat="server" Text="Category"></asp:Label></td>
        
                          <td><asp:TextBox ID="TextBox11" runat="server" PlaceHolder="Category" Height="23px" Width="195px"></asp:TextBox></td>
          </tr>
           <tr>
                             <td><asp:Label ID="Label13" runat="server" Text="Name of the School Last Attended"></asp:Label></td>
                              <td><asp:TextBox ID="TextBox12" runat="server" PlaceHolder="Last Attended School" Height="23px" Width="129px"></asp:TextBox></td>
            </tr>
            <tr>
                         <td><asp:Label ID="Label14" runat="server" Text="Class"></asp:Label></td> 
                         <td><asp:TextBox ID="TextBox13" runat="server" PlaceHolder="Class" Height="23px" Width="195px"></asp:TextBox></td>
            </tr>
            <tr>
                        <td><asp:Label ID="Label15" runat="server" Text="Residential Address"></asp:Label></td>
        
                        <td><asp:TextBox ID="TextBox14" runat="server" PlaceHolder="Residential Address" Height="23px" Width="195px"></asp:TextBox></td>
             </tr>
             <tr>
                           <td><asp:Label ID="Label16" runat="server" Text="City"></asp:Label></td>
                              <td><asp:TextBox ID="TextBox15" runat="server" PlaceHolder="City" Height="23px" Width="195px"></asp:TextBox></td>
             </tr>
             <tr><td>
                     Medical Information
               <br />( is compulsory)</td>
              </tr>
               <tr>
                      <td><asp:Label ID="Label17" runat="server" Text="Blood Group"></asp:Label></td>
                      <td>    <asp:DropDownList ID="DropDownList2" runat="server">
                                 <asp:ListItem >A+</asp:ListItem>
                                 <asp:ListItem >A-</asp:ListItem>
                                 <asp:ListItem >B+</asp:ListItem>
                                 <asp:ListItem >B-</asp:ListItem>
                                 <asp:ListItem >AB+</asp:ListItem>
                                 <asp:ListItem >AB-</asp:ListItem>
                                 <asp:ListItem >O+</asp:ListItem>
                                 <asp:ListItem >O-</asp:ListItem>
                              </asp:DropDownList>
                      </td>
              </tr>
              <tr>
                      <td><asp:Label ID="Label18" runat="server" Text="Identification Mark"></asp:Label></td>
                        <td><asp:TextBox ID="TextBox17" runat="server" PlaceHolder="Identification Mark" Height="23px" Width="195px"></asp:TextBox></td>
              </tr>
              <tr>
                   <td><asp:Label ID="Label19" runat="server" Text="Upload image"></asp:Label></td>
                   <td>
                       <asp:FileUpload ID="FileUpload1" runat="server" Width="195px"/>
                   </td>
              </tr>
            </table>
            <table>
                <tr>
                    <td><asp:Label ID="Label20" runat="server" Text="Image preview"></asp:Label></td>
                    <td>
                        <asp:Image ID="Image2" runat="server" />
                       <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
                    </td>
                 </tr>
            </table>
            <table>
                <tr>
                    <td><asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" /></td>
                    <td><asp:Button ID="Button2" runat="server" Text="Retrieve" OnClick="Button2_Click" /></td>
                    <td><asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" /></td>
                    <td><asp:Button ID="Button4" runat="server" Text="New" OnClick="Button4_Click" /></td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                   <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                             <asp:Button runat="Server" Text="Delete" CommandName ="Select" ButtonType="Button" onClick="btn_click" />
                        </ItemTemplate>
                   </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                       <ItemTemplate>
                             <asp:Button runat="Server" Text="Select" CommandName ="Select" ButtonType="Button" onClick="btn_click2" />
                       </ItemTemplate>
                    </asp:TemplateField>
                 </Columns>
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                              <asp:Button runat="Server" Text="Print" CommandName ="Select" ButtonType="Button" onClick="btn_click3" />
                        </ItemTemplate>
                    </asp:TemplateField>
                 </Columns>
            </asp:GridView>
        </form>
</body>
</html>
