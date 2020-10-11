<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Maintenance.aspx.cs" Inherits="Final.WebForm2" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="margin-left:400px;">Inventory Maintenance  
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" style="position: absolute ; top: 160px; left: 600px;"></asp:Label>
        <asp:Label ID="Label5"  runat="server" style="position: absolute ; top: 140px; left: 140px;" Text="Choose Item"></asp:Label>

        <asp:Label ID="Label2" runat="server" style="position: absolute; top: 210px; left: 524px;" Text="Item Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="position: absolute; top: 249px; left: 530px; width: 57px;" Text="On-Hand"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 530px; top: 288px; position: absolute; height: 23px; width: 62px" Text="Unit Cost"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 494px; top: 328px; position: absolute; height: 16px; width: 102px;" Text="ReOrder Point"></asp:Label>



        <asp:TextBox ID="TextBox3" runat="server" Style="position: absolute; top: 205px; left: 600px; "></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="position: absolute;  top: 243px;  left: 605px; "></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Style="position: absolute;  top: 282px;  left: 605px; "></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>


        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="ItemName" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SportsConnectionString2 %>" SelectCommand="SELECT * FROM [Items] ORDER BY [ItemName]"></asp:SqlDataSource>
        <asp:Button   Style="position: absolute;  top: 310px;  left: 600px; height: 22px; width: 119px; top: 400px;"  ID ="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="Label4" runat="server" style="position: absolute ; top: 440px; left: 630px;"></asp:Label>
    </p>
  

</asp:Content>

