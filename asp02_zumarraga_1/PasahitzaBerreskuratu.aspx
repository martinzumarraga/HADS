<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PasahitzaBerreskuratu.aspx.vb" Inherits="ErabiltzaileErregistratuak.PasahitzaBerreskuratu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label4" runat="server" Text="Sartu zure eposta:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonOk" runat="server" Text="Ok" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelErroreaEmail" runat="server" ForeColor="Red" Text="Email hau ez da egokia" Visible="False"></asp:Label>
        <br />
    
        <asp:Label ID="LabelGalderaText" runat="server" Text="Galdera eskutua: " Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelGaldera" runat="server" Text="Galdera" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelErantzuna" runat="server" AssociatedControlID="TextBoxErantzuna" Text="Sartu erantzuna: " Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxErantzuna" runat="server" Visible="False"></asp:TextBox>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEgiaztatu" runat="server" Text="Egiaztatu" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelPasahitza" runat="server" Text="ErantzunariErantzuna" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Login</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
