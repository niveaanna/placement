<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="gridview.aspx.cs" Inherits="Placement_Cell.gridview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="nav-justified">
       
        <tr>
            <td colspan="2">Question </td>
            <td>
               &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </td>
            
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddl1" runat="server"></asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddl2" runat="server"></asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            
        </tr>
           </table>
    <table>
        <tr> &nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" 
                            HeaderStyle-BackColor="Red" HeaderStyle-ForeColor="White" Height="82px" 
                             OnRowDataBound="GridView2_RowDataBound">
                            <Columns>
                               <asp:TemplateField HeaderText="Checkbox" >
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chb1" runat="server" Checked="false" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Option">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtA"  runat="server">
                                        </asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               
                            
                            </Columns>
                        </asp:GridView>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <br />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
 </table>

</asp:Content>
