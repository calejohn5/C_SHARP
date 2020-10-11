<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Issues.aspx.cs" Inherits="Final.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <h2 style="margin-left:400px;">Inventory Issues  
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" style="position: absolute ; top: 160px; left: 600px;"></asp:Label>
        <asp:Label ID="Label5"  runat="server" style="position: absolute ; top: 140px; left: 140px;" Text="Choose Item"></asp:Label>

        <asp:Label ID="Label2" runat="server" style="position: absolute ; top: 200px; left: 530px;" Text="Quantity:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="position: absolute; top: 250px; left: 544px;" Text="Date:"></asp:Label>

        <asp:TextBox ID="TextBox3" runat="server" Style="position: absolute; top: 205px; left: 600px; "></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="position: absolute;  top: 244px;  left: 605px; "></asp:TextBox>


        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SportsConnectionString2 %>" SelectCommand="SELECT [Id], [Name] FROM [Supplier] ORDER BY [Name]"></asp:SqlDataSource>


        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ItemName" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SportsConnectionString2 %>" SelectCommand="SELECT [ItemName], [id] FROM [Items]"></asp:SqlDataSource>
        <asp:Button   Style="position: absolute;  top: 310px;  left: 600px; height: 22px; width: 119px; bottom: 242px;"  ID ="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="Label4" runat="server" style="position: absolute ; top: 360px; left: 630px;"></asp:Label>
    </p>
  
    </asp:Content>

