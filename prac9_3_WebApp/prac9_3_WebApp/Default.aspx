<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="prac9_3_WebApp._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="width:40%">
   <div style="background-color:Aqua; color:Black; font-size:large; font-weight:bolder">&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Calculator using WCF</div>
    <br />
     <div style="color:Black;font-size:medium; font-weight:bolder">
        
     Number 1 : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />

     Number 2 : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         
     </div>
     <br />

     <div>
         <asp:Button ID="Button1" runat="server" Text="Add" BackColor="Aqua" 
             Font-Bold="True" Font-Size="Medium" ForeColor="Black" 
             onclick="Button1_Click" /> &nbsp;
         <asp:Button ID="Button2" runat="server" Text="Sub" BackColor="Aqua" 
             Font-Bold="True" Font-Size="Medium" ForeColor="Black" onclick="Button2_Click" 
             />   &nbsp;
         <asp:Button ID="Button3" runat="server" Text="Mul" BackColor="Aqua" 
             Font-Bold="True" Font-Size="Medium" ForeColor="Black" onclick="Button3_Click1" 
             />   &nbsp;  

         <asp:Button ID="Button4" runat="server" Text="Div" BackColor="Aqua" 
         Font-Bold="True" Font-Size="Medium" ForeColor="Black" onclick="Button4_Click"
          />   &nbsp;  
     
     </div>
     <br />

     <div style="color:Black;font-size:medium; font-weight:bolder">
     
     Result: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
     </div>
  
  
   </div>
   
</asp:Content>
