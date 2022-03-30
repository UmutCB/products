<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Product.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Product</h2>
    <div>
        <div><label>Product Name</label></div>
        <div>
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></div>
         <div><label>Expiry Date</label></div>
        <div>
            <asp:TextBox ID="expiryTextBox" runat="server"></asp:TextBox></div>
         <div><label>Amount</label></div>
        <div>
            <asp:TextBox ID="amountTextBox" runat="server"></asp:TextBox></div>
         <div><label>Currency</label></div>
        <div>
            <asp:TextBox ID="currencyTextBox" runat="server"></asp:TextBox></div>
         <div><label>Active Status</label></div>
        <div>
            <asp:CheckBox ID="isActive" runat="server" /> </div>
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
    </div>
</asp:Content>
