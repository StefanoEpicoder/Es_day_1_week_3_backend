<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Es_day_1_week_3_backend._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <p runat="server" id="testParagrafo"></p>
        <p runat="server" id="testParagrafo2"></p>

    </main>

</asp:Content>
