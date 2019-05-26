<%@ Page Language="C#" Inherits="CarPartsUltimate.Default" CodeBehind="Default.aspx.cs" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
        <link href="~/CSS/styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<form id="form1" runat="server">
        <div id="app">
            <asp:PlaceHolder id="HeaderNavigation" runat="server" />
            <asp:PlaceHolder id="DefaultControls" runat="server" />
        </div>
	</form>
    <script src="https://cdn.jsdelivr.net/npm/vue/dist/vue.js"></script>
    <script type="text/javascript" src="~/Scripts/script.js"></script>
    <script type="text/javascript" src="~/Scripts/vechicleSelection.js"></script> 
                <script type="text/javascript" src="~/Scripts/vehicleSelectionTile.js"></script>
</body>
</html>
