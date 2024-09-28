<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="simulador_seguros.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Formulário do usuário</h1>
    <h2>Faça aqui o seu cadastro para simular o seguro desejado:</h2>

    <asp:Label ID="Label_nome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="Nome" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label_data_nascimento" runat="server" Text="Data de nascimento" AssociatedControlID="Data_nascimento"></asp:Label>
    <asp:TextBox ID="Data_nascimento" runat="server" TextMode="Date"></asp:TextBox><br />
      
    <asp:Label ID="Label_cpf" runat="server" Text="CPF"></asp:Label>
    <asp:TextBox ID="cpf" runat="server"></asp:TextBox><br />

    <br /><asp:Label ID="Label_lista_seguros" runat="server" Text="Tipos de seguros:"></asp:Label><br />
    <asp:RadioButtonList ID="RadioButtonList_seguros" runat="server">
        <asp:ListItem>Seguro de vida</asp:ListItem>
        <asp:ListItem>Seguro de morte acidental</asp:ListItem>
        <asp:ListItem>Seguro contra acidentes pessoais</asp:ListItem>
        <asp:ListItem>Seguro de saúde</asp:ListItem>
        <asp:ListItem>Seguro de automóvel</asp:ListItem>
        <asp:ListItem>Seguro residencial</asp:ListItem>
        <asp:ListItem>Seguro patrimonial</asp:ListItem>
        <asp:ListItem>Seguro empresarial</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Button ID="Button_enviar" runat="server" Text="Enviar" OnClick="Enviar_dados" />

    <asp:Label ID="ResultadoLabel" runat="server" Text=""></asp:Label>
</asp:Content>
