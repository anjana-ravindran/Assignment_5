<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Assignment_5.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            height:283px;
            width:446px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td colspan="2" style="text-align:center"><b><h1>EMPLOYEE</h1></b></td>
                </tr>
                <tr>
                    <td><b>Employee Name</b></td>
                    <td>
                      <asp:TextBox ID="txtempname" runat="server" required=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><b>Age</b></td>
                    <td>
                      <asp:TextBox ID="txtage" runat="server" required=""></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td><b>Email</b></td>
                    <td>
                      <asp:TextBox ID="txtemail" runat="server" required=""></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td><b>Phone</b></td>
                    <td>
                      <asp:TextBox ID="txtphone" runat="server" required=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                          <br />
                        <asp:Button ID="btn_Add" runat="server" Text="Add" OnClick="btn_Add_Click" />
                          <br />
                          <br />
                    </td>
                </tr>
                    <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Employee_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="647px">
                            <Columns>
                                <asp:TemplateField  HeaderText="SI. No.">
                                 <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                 </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Employee_Name" HeaderText="Employee Name" />
                                <asp:BoundField DataField="Age" HeaderText="Age" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                                <asp:HyperLinkField HeaderText="View More" Text="Go" DataNavigateUrlFields="Employee_id" DataNavigateUrlFormatString="Test.aspx?id={0}" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
             </table>
        </div>
    </form>
</body>
</html>
