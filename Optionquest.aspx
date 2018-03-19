<%@ Page Title="" Language="C#" MasterPageFile="~/student.Master" AutoEventWireup="true" CodeBehind="Optionquest.aspx.cs" Inherits="Placement_Cell.Optionquest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate>
                <p>
                <asp:Label ID="Label" runat="server" Text='<%#Eval("Question") %>'></asp:Label>
                    </p>
            </ItemTemplate>
    </asp:Repeater>
</asp:Content>

