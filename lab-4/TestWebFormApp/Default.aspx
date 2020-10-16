<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWebFormApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
            <asp:TextBox runat="server" ID="x" />
            <asp:TextBox runat="server" ID="y" />
            <asp:Button runat="server" ID="sum" OnClick="sum_Click" Text="Sum" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="result" />
        </div>

</asp:Content>
