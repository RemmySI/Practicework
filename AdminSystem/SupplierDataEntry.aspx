<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="height: 718px">
            <asp:Label ID="lblsupplierNo" runat="server" Text="Supplier No" width="122px"></asp:Label>
            :
            <asp:TextBox ID="supplierNo" runat="server" BorderColor="Black" BorderStyle="Double" ValidateRequestMode="Enabled" width="122px"></asp:TextBox>
            <br />
            <asp:Label ID="lblsupplierName" runat="server" Text="Supplier Name" width="122px"></asp:Label>
            :
            <asp:TextBox ID="supplierName" runat="server" BorderColor="Black" BorderStyle="Double" height="27px" width="122px"></asp:TextBox>
            <br />
            <asp:Label ID="lblsupplierContactNo" runat="server" Text="Supplier ContactNo" width="161px"></asp:Label>
            :
            <asp:TextBox ID="supplierContactNo" runat="server" BorderColor="Black" BorderStyle="Double" height="27px" width="122px"></asp:TextBox>
            <br />
            <asp:Label ID="lblsupplierEmail" runat="server" Text="Supplier Email" width="122px"></asp:Label>
            :
            <asp:TextBox ID="supplierEmail" runat="server" BorderColor="Black" BorderStyle="Double" height="27px" width="122px"></asp:TextBox>
            <br />
            <asp:Label ID="lblsupplierAddress" runat="server" Text="Supplier Address" width="159px"></asp:Label>
            :
            <asp:TextBox ID="supplierAddress" runat="server" BorderColor="Black" BorderStyle="Double" height="27px" width="122px"></asp:TextBox>
            <br />
            <asp:Label ID="lbldateRegistered" runat="server" Text="Date of Register" width="146px"></asp:Label>
            :<asp:TextBox ID="dateRegistered" runat="server" BorderColor="Black" BorderStyle="Double" height="27px" width="122px"></asp:TextBox>
&nbsp;<br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
&nbsp;<br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="Add_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
