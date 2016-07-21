<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="horas.aspx.cs" Inherits="horas.horas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div><asp:Label ID="Label2" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Selecione um dia: "></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Suas horas foram: "></asp:Label>
    </div>
</asp:Content>
