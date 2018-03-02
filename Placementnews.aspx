<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Placementnews.aspx.cs" Inherits="placement.Placementnews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 232px;
        }
        .auto-style3 {
            width: 199px;
        }
        .auto-style4 {
            width: 232px;
            height: 23px;
        }
        .auto-style5 {
            width: 199px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Company Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtcompanyname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Required Post"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtpost" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Criteria"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtcriteria" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Year"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtyear" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Venue</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtvenue" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Other Information"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtinformation" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="CLEAR" OnClick="Button2_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
