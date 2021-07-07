<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllEmployees.aspx.cs" Inherits="WebApplication1.AllEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="MyGridView" runat="server" EnablePersistedSelection="True">
        </asp:GridView>
    </form>
</body>
</html>
