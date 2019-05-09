<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoogleAuthWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h4 style="font-size: large"><strong>Google OAuth Authentication with Google Drive API - MS19803876</strong></h4>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press this to get Google Drive Contents" Width="239px" />
        </p>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Width="1346px"></asp:ListBox>
        </p>
    </div>

    </asp:Content>
