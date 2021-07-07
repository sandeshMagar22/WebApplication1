<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employeeold.aspx.cs" Inherits="WebApplication1.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> All Employees of ICMS</h1>
        </div>
        <asp:Label ID="LabelMainTitle" runat="server" BackColor="Black" BorderColor="Red" BorderStyle="Dotted" CssClass="bigTitle" ForeColor="Yellow" Text="Welcome to all the Staffs."></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSourceEmpData">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="roll_no" HeaderText="roll_no" SortExpression="roll_no" />
                <asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname" />
                <asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname" />
                <asp:BoundField DataField="addressofstudent" HeaderText="addressofstudent" SortExpression="addressofstudent" />
                <asp:BoundField DataField="phonenumber" HeaderText="phonenumber" SortExpression="phonenumber" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceEmpData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [students]"></asp:SqlDataSource>
    </form>
</body>
</html>
