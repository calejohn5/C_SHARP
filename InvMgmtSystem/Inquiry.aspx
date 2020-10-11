<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inquiry.aspx.cs" Inherits="Final.Inquiry" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Inquiries </h2>

            <div class="row">
                <div class="col-xs-12">
                    <asp:GridView ID="grdProducts" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" DataKeyNames="id" 
                        CssClass="table table-bordered table-condensed" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="id"
                                ReadOnly="True" InsertVisible="False" SortExpression="id" Visible="False">
                            </asp:BoundField>
                            <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName">
                            </asp:BoundField>
                            <asp:BoundField DataField="QtyOnHand" HeaderText="QtyOnHand" SortExpression="QtyOnHand">
                            </asp:BoundField>
                            <asp:BoundField DataField="ReorderPoint" HeaderText="ReorderPoint" SortExpression="ReorderPoint" />
                            <asp:BoundField DataField="CostPer" HeaderText="CostPer" SortExpression="CostPer" />
                            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
                        </Columns>
                        <HeaderStyle CssClass="bg-halloween" />
                        <AlternatingRowStyle CssClass="altRow" />
                        <EditRowStyle CssClass="warning" />
                    </asp:GridView> 
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SportsConnectionString2 %>" SelectCommand="SELECT * FROM [Items] ORDER BY [ItemName]"></asp:SqlDataSource>
                </div>  
            </div>
</asp:Content>

