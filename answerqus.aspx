<%@ Page Title="" Language="C#" MasterPageFile="~/student.Master" AutoEventWireup="true" CodeBehind="answerqus.aspx.cs" Inherits="Placement_Cell.answerqus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<!DOCTYPE html>


    <div>
        
            
       <asp:Repeater ID="rptQues" runat="server"  OnItemDataBound="Repeater1_ItemDataBound">
       
            
        <ItemTemplate>
       
          <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("Qus_id") %>' Visible="False" />
               
               
                <asp:Label ID="lblques" runat="server" Text='<%# Eval("Question") %>' />
            <asp:RadioButtonList ID="rdoTest" runat="server"></asp:RadioButtonList>
         <%--   <asp:PlaceHolder ID="plchldr" runat="server">


            </asp:PlaceHolder>--%>
            <%--<asp:RadioButtonList runat="server" ID="rdolst"></asp:RadioButtonList>--%> 
                   <asp:Repeater ID="rptOption" runat="server">                        
                        <ItemTemplate >
                            
                            <%-- <asp:RadioButton ID="rbopt" runat="server" Text='<%# Eval("Options") %>' />--%>
                           <%-- <asp:RadioButton  GroupName="abc" runat="server" Text='<%# Eval("Options") %>' />--%>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataValueField='<%# Eval("Options") %>'>
                               <%-- <asp:ListItem Text='<%# Eval("Options") %>'></asp:ListItem>--%>
                            </asp:RadioButtonList>

                        </ItemTemplate>
                        
                    </asp:Repeater>
            <br />
             
    </ItemTemplate>
   </asp:Repeater>
        
            
    </div>
    <asp:Button ID="Button1" runat="server" Text="SUBMIT" />

</asp:Content>
