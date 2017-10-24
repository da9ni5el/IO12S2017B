<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IO1_Project.GUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">        
        <h1 class="panel-title">Iniciar Sesion</h1>
        <br />
        <div class="input-group">
            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
            <asp:TextBox ID="iduser" runat="server" CssClass="form-control" Width="300px" placeholder="Ingresa tu nombre de usuario" ValidationGroup="error"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo incorrecto o vacio" ForeColor="red" ValidationGroup="error" ControlToValidate="iduser"></asp:RequiredFieldValidator>
        </div>
        <div class="input-group">
            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
            <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password" Width="300px" placeholder="Ingresa tu contraseña" ValidationGroup="error"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo incorrecto o vacio" ForeColor="red" ValidationGroup="error" ControlToValidate="password"></asp:RequiredFieldValidator>
        </div>
        <div class="input-group">
            <asp:Button ID="enviar" runat="server" CssClass="btn btn-lg btn-default" Text="Iniciar" OnClick="enviar_Click" />
        </div>
        <div id="salida" runat="server" class="alert alert-danger">

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
