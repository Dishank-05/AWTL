<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prac5_2_Disconnected_Architecture._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
               
            <h2> ADO.NET Program Fetching Student Details Using </br>
 &nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;DISCONNECTED ARCHITECTURE. </h2>
            </hgroup>
            <div>

                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />

            </div>
        </div>
    </section>
</asp:Content>

