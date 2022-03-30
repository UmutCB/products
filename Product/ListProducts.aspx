<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="Product.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>PRODUCTS</h2>
    <div>
         <label>Search by name</label>
    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="nameButton" runat="server" Text="Search" OnClick="nameButton_Click" />
    </div>
    <div>
         <label>Search by date</label>
    <asp:TextBox ID="dateTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="dateButton" runat="server" Text="Search" OnClick="dateButton_Click" />
    </div>
    <asp:GridView ID="dataGrid" runat="server" AutoGenerateColumns="false" EmptyDataText="G&#246;r&#252;nt&#252;lenecek hi&#231; veri kaydı yok." AllowPaging="true">
<Columns>
    <asp:BoundField HeaderStyle-Width="150px" DataField="productName" HeaderText="Product Name" />
    <asp:BoundField HeaderStyle-Width="150px" DataField="expiryDate" HeaderText="Expiry Date" />
    <asp:BoundField HeaderStyle-Width="150px" DataField="amount" HeaderText="Amount" />
     <asp:BoundField HeaderStyle-Width="150px" DataField="currency" HeaderText="Currency" />
     <asp:BoundField HeaderStyle-Width="150px" DataField="isActive" HeaderText="Active Status" />
</Columns>
</asp:GridView>
    
</asp:Content>
