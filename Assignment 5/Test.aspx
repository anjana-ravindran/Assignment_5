<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Assignment_5.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Name: <asp:Label ID="lblempname" runat="server" Text="Label"></asp:Label>
            &nbsp;
            <br />
            <br />
            Age:&nbsp;&nbsp;&nbsp; <asp:Label ID="lblempage" runat="server" Text="Label"></asp:Label>
             &nbsp;
            <br />
            <br />
            Email: <asp:Label ID="lblempemail" runat="server" Text="Label"></asp:Label>
             &nbsp;
            <br />
            <br />
            Phone: <asp:Label ID="lblempphone" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
