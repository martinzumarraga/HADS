<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PasahitzaAldatu.aspx.vb" Inherits="ErabiltzaileErregistratuak.PasahitzaAldatu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelLehenengoPasahitza" runat="server" AssociatedControlID="TextBoxLehenengoPasahitza" Text="Lehengo pasahitza:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxLehenengoPasahitza" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelPasahitzBerria" runat="server" AssociatedControlID="TextBoxPasahitzBerria" Text="Pasahitz berria:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPasahitzBerria" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelPasahitzBerriaBerriro" runat="server" AssociatedControlID="TextBoxPasahitzBerriaBerriro" Text="Pasahitz berria (Berriro):"></asp:Label>
        <asp:TextBox ID="TextBoxPasahitzBerriaBerriro" runat="server" TextMode="Password"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
