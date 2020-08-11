<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayersControl.aspx.cs" Inherits="WebControlsAssign.PlayersControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select Game<br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cricket Players" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Tennis Players" />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Width="315px">
                &nbsp;<asp:HyperLink ID="HyperLinkSachin" runat="server" NavigateUrl="~/SachinDetails.html">Sachin Tendulkar</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLinkVirat" runat="server" NavigateUrl="~/ViratDetails.html">Virat Kohli</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLinkDhoni" runat="server" NavigateUrl="~/DhoniDetails.html">MS Dhoni</asp:HyperLink>
                &nbsp;<br />
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Width="314px">
                <asp:HyperLink ID="HyperLinkMartina" runat="server" NavigateUrl="~/MartinaDetails.html">Martina Hingis</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLinkAndre" runat="server" NavigateUrl="~/AndreDetails.html">Andre Agassi</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLinkJean" runat="server" NavigateUrl="~/BillieDetails.html">Billie Jean King</asp:HyperLink>
                <br />
            </asp:Panel>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
