<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSelector.aspx.cs" Inherits="Products_prj_AA1_.ProductSelector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        label {
            display: block;
            margin-top: 10px;
        }
        input, select {
            width: 300px;
            padding: 8px;
            margin-top: 5px;
        }
        button {
            margin-top: 15px;
            padding: 10px 15px;
        }
</style>
</head>
<body>
<form id="form1" runat="server">
<h2>Select a Product</h2>
 
        <label for="ddlProducts">Products:</label>
<asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
</asp:DropDownList>
 
        <asp:Image ID="imgProduct" runat="server" Width="200px" Height="200px" />
<h3>Price: <asp:Label ID="lblPrice" runat="server"></asp:Label></h3>
 
        <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
</form>
</body>
</html>