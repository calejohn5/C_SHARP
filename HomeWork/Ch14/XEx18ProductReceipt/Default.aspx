<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XEx18ProductReceipt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch18: Product Receipt</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
    <header class="jumbotron"><%-- image set in site.css --%></header>
    <main>
        <form id="form1" runat="server" class="form-horizontal">

            <div class="form-group">
                <label class="col-sm-3">Please select a category</label>
                <div class="col-sm-4">
                    <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" 
                        CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row">
                <div class="col-xs-12">
                    <asp:GridView ID="grdProducts" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" DataKeyNames="ProductID" 
                        CssClass="table table-bordered table-condensed">
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="ID"
                                ReadOnly="True">
                                <HeaderStyle CssClass="col-sm-2" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Name" HeaderText="Name" 
                                ReadOnly="True">
                                <HeaderStyle CssClass="col-sm-6" />
                            </asp:BoundField>
                            <asp:BoundField DataField="OnHand" HeaderText="OnHand">
                                <HeaderStyle CssClass="col-sm-2 text-right" />
                                <ItemStyle CssClass="text-right"></ItemStyle>
                            </asp:BoundField>
                            <asp:CommandField ShowEditButton="True" />
                        </Columns>
                        <HeaderStyle CssClass="bg-halloween" />
                        <AlternatingRowStyle CssClass="altRow" />
                        <EditRowStyle CssClass="warning" />
                    </asp:GridView> 
                </div>  
            </div>

            <div class="row">
                <div class="col-xs-12">
                    <p><asp:Label ID="lblError" runat="server" 
                        CssClass="text-danger" EnableViewState="false"></asp:Label></p>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        HeaderText="Please correct the following errors:" CssClass="text-danger" />
                </div>
            </div>
        </form>
    </main>
</div>
</body>
</html>