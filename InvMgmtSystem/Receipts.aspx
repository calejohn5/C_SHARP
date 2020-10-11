<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receipts.aspx.cs" Inherits="Final.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    <h2 style="margin-left:500px;"> Receipts 
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" style="position: absolute ; top: 150px; left: 700px;"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="left: 700px; top: 174px; position: absolute"></asp:Label>

       <asp:Label ID="Label5"  runat="server" style="position: absolute ; top: 140px; left: 140px;" Text="Choose Item"></asp:Label>
        <asp:Label ID="Label6"  runat="server" style="position: absolute ; top: 140px; left: 340px;" Text="Choose Supplier"></asp:Label>


        <asp:Label ID="Label2" runat="server" style="position: absolute ; top: 200px; left: 630px;" Text="Quantity:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="position: absolute ; top: 240px; left: 630px;" Text="Date:"></asp:Label>
        <asp:DropDownList ID="DropDownList2" style="position: absolute; top: 180px; left: 330px; height: 16px;" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">     </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SportsConnectionString2 %>" SelectCommand="SELECT [Name],[Id] FROM [Supplier] ORDER BY [Name]"></asp:SqlDataSource>

        <asp:TextBox ID="TextBox1" runat="server" Style="position: absolute; top: 200px; left: 700px; "></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="position: absolute;  top: 240px;  left: 700px; "></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ItemName" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SportsConnectionString2 %>" SelectCommand="SELECT [ItemName], [id] FROM [Items]"></asp:SqlDataSource>
        <asp:Button   Style="position: absolute;  top: 310px;  left: 700px; height: 22px; width: 119px; bottom: 242px;"  ID ="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="Label4" runat="server" style="position: absolute ; top: 360px; left: 730px;"></asp:Label>
    </p>
</asp:Content>
