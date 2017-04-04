<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IkasleLanGenerikoak.aspx.vb" Inherits="ErabiltzaileErregistratuak.IkasleLanGenerikoak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownListIrakasgaiak" runat="server">
        </asp:DropDownList>
        <br />
        <asp:CheckBoxList ID="CheckBoxListZehaztasunak" runat="server">
            <asp:ListItem>Kodea</asp:ListItem>
            <asp:ListItem>Deskribapena</asp:ListItem>
            <asp:ListItem>Aurreik. orduak</asp:ListItem>
            <asp:ListItem>Lan mota</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="ButtonIkusiLanak" runat="server" Text="Ikusi lanak" />
        <br />
        <br />
        <asp:Label ID="LabelEzDagoLanik" runat="server" Text="Ez dago irakasgai honen lanik" Visible="False"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
