<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="pdf.aspx.cs" Inherits="Placement_Cell.pdf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="nav-justified">
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td style="width: 234px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px; width: 561px"></td>
            <td style="width: 234px; height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <a href='<%# "Upload folder/"+Eval("file_name") %>' target="_blank">View</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
            <td style="width: 234px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
