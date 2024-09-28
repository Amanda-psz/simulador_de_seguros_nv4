<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="simulador_seguros.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Resultado do Cálculo</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Resultado da Simulação</h1>

    <asp:Label ID="LabelResultado" runat="server" Text=""></asp:Label>
</asp:Content>
