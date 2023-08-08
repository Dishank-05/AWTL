<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="prac7_web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoPostBack="true">
        </asp:GridView>
        <br />
&nbsp; Name&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp; Email&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp; Roll No
        <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp; Program&nbsp;
        <asp:TextBox ID="txtProgram" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Button ID="btnPrevious" runat="server" OnClick="btnPrevious_Click" Text="Previous" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
        <br />
    
    </div>
    </form>
</body>
</html>
