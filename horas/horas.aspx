<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="horas.aspx.cs" Inherits="horas.horas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
    <div><asp:Label ID="Label2" runat="server" Text="Selecione um usuario: "></asp:Label>
        </div>
        <div>
         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="usua_log" DataValueField="usua_log">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT usua_log FROM bethadba.geloguser ORDER BY usua_log asc"></asp:SqlDataSource>
       
    </div>
        </br>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Selecione um dia: "></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular" />
        </br>
    <div>
        <asp:Label ID="Label1" runat="server" Text="" ></asp:Label>
    </div>
        </center>
</asp:Content>
