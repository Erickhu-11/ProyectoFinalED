<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmprincipal.aspx.cs" Inherits="Programa1.frmprincipal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Primer Programa C#</title>
    <link href="HojaEstilos/Programa1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            font-familY: Comic Sans MS;
            font-size: 30px;
            text-align: center;
            background-color: Gray;
            width: 496px;
            height: 46px;
        }
        .style2
        {
            font-family: Arial;
            font-size: 20px;
            text-align: center;
            background-color: Green;
            color: Black;
            width: 496px;
        }
        .style3
        {
            width: 496px;
        }
        .style6
        {
            font-familY: Comic Sans MS;
            font-size: 30px;
            text-align: center;
            background-color: Gray;
            height: 46px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="style1">
                    &nbsp;
                    Universidad Hispanoamericana</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp; Programacion 3</td>
            </tr>
            <tr>
                <td id="MnuPrincipal" class="style3">
                    <br />
                    <asp:Menu ID="mnuPrincipal" runat="server" BackColor="#FFFBD6" 
                        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
                        ForeColor="#990000" 
                        StaticSubMenuIndent="10px" onmenuitemclick="mnuPrincipal_MenuItemClick">
                        <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#FFFBD6" />
                        <DynamicSelectedStyle BackColor="#FFCC66" />
                        <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#FFCC66" />
                    </asp:Menu>
                    <br />
                </td>
            </tr>
        </table>
    </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
