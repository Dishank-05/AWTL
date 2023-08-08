<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="prac9_2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            Id<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Name 
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Email<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
           
            <br />
            <asp:Label ID="Label2" runat="server" Text="Status :"></asp:Label>

            <asp:Label ID="Label1" runat="server">_______</asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
                Text="Insert" />

    </div>
    </form>
</body>
</html>
