<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Master.Master" AutoEventWireup="true" CodeBehind="Registro_User.aspx.cs" Inherits="IO1_Project.GUI.Registro_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="modal-title">Formulario de Registro</h1>
    <br />            
         <%--<span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>--%>
    <div class="input-group">
        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
        <asp:TextBox ID="iduser" runat="server" CssClass="form-control" Width="350px" placeholder="Ingresa tu Alias" ValidationGroup="error"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="error" ControlToValidate="iduser"></asp:RequiredFieldValidator>
    </div>
    <div class="input-group">
        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
        <asp:TextBox ID="nombre" runat="server" CssClass="form-control" Width="350px" placeholder="Ingresa tu nombre"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="error" ControlToValidate="nombre"></asp:RequiredFieldValidator>
    </div>
    
    <div class="input-group">
        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
        <asp:TextBox ID="apellido" runat="server" CssClass="form-control" Width="350px" placeholder="Ingresa tu apllido"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="error" ControlToValidate="apellido"></asp:RequiredFieldValidator>
    </div>              
    
    <div class="input-group">
        <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
        <asp:TextBox ID="email" runat="server" CssClass="form-control" Width="350px" placeholder="Ingresa tu correo electronico"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="error" ControlToValidate="email"></asp:RequiredFieldValidator>
    </div>

    <div class="input-group">
        <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
        <asp:TextBox ID="passwd" runat="server" CssClass="form-control" TextMode="Password" Width="350px" placeholder="Ingresa tu contraseña"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="error" ControlToValidate="passwd"></asp:RequiredFieldValidator>
    </div>
    <div class="input-group">
        <asp:Button ID="enviar" runat="server" CssClass="btn btn-default btn-lg" Text="Enviar" OnClick="enviar_Click" />
    </div>
    <%
        string respuesta = Request.QueryString["register"];
        if (respuesta=="true")
        {
            Response.Write(" <div class= \"alert alert-success\"> <strong>Hecho!</strong>Se ha registrado tu cuenta exitosamente. </ div > ");
        }
        else if (respuesta == "false")
        {
            Response.Write(" <div class=\"alert alert-danger\"> <strong>Error</strong> Ha ocurrido un error al tratar de registrar tu cuenta. Revisa tus datos y vuelve a intentarlo. </ div > ");
        }    

    %>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
