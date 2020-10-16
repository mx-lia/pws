<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWebFormApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div style="margin:10px">
            <asp:TextBox runat="server" ID="x" />
            <span>+</span>
            <asp:TextBox runat="server" ID="y" />
            <asp:Button runat="server" ID="sum" OnClick="sum_Click" Text="=" />
            <asp:Label runat="server" ID="result" />
        </div>

</asp:Content>
