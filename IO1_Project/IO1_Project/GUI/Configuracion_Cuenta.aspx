<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Master.Master" AutoEventWireup="true" CodeBehind="Configuracion_Cuenta.aspx.cs" Inherits="IO1_Project.GUI.Configuracion_Cuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <ul class="nav navbar-nav navbar-right">
        <li><a href="#"><span class="glyphicon glyphicon-shopping-cart"></span>Carrito de Compra</a></li>

        <%
            
            if (currentrol == "0")
            {
                Response.Write("<li><a href=#><span class=\"glyphicon glyphicon-user\"></span>Mi Cuenta</a></li>");
                Response.Write("<li><a href=\"Inicio.aspx?logout=true\"><span class=\"glyphicon glyphicon-log-in\"></span>Logout</a></li>");
            }
            else
            {
                Response.Write("<li><a href=\"Registro_User.aspx\"><span class=\"glyphicon glyphicon-user\"></span>Registro</a></li>");
                Response.Write("<li><a href=\"Login.aspx\"><span class=\"glyphicon glyphicon-log-in\"></span>Login</a></li>");
            }

        %>       
            
        <%--<li><a href="Registro_User.aspx"><span class="glyphicon glyphicon-user"></span>Registrarse</a></li>--%>
        <%-- esta parte se mostrara de acuerdo al estado de la sesion--%>
        <%--<li><a href="Login.aspx"><span class="glyphicon glyphicon-log-in"></span>Login</a></li>--%>
        <%--Cambiara de acuerdo al estado de la sesion. --%>        
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1><strong>Configuracion de la Cuenta</strong></h1>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <div class="pull-right">
            <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar" ForeColor="red" OnClick="btnEditar_Click"/>
        </div>
    <div class=" panel panel-primary">     
        <div class="row">                    
                <div class="col-3">                    
                    <div class="pull-right">
                        <strong>Nickname:</strong>
                    </div>
                    <br />
                    <div class="pull-right">
                        <strong>Nombre:</strong>
                    </div>
                    <br />
                    <div class="pull-right">
                        <strong>Apellido:</strong>
                    </div>
                    <br />
                    <div class="pull-right">
                        <strong>Contraseña:</strong>
                    </div>
                    <br />
                    <div class="pull-right">
                        <strong>Correo electronico:</strong>
                    </div>
                    <br />
                    <div class="pull-right">
                        <strong>Direcion:</strong>
                    </div>
                    <br />
                    <div class="pull-right">
                        <strong>Telefono:</strong>
                    </div>
                    <br />                
            </div>
            <div class="col-9">
                <div class="pull-left">
                    <strong id="nicktxt" runat="server"></strong>
                </div>
                <br />
                <div class="pull-left">
                    <strong id="nametxt" runat="server"></strong>
                </div>
                <br />
                <div class="pull-left">
                    <strong id="apellidotxt" runat="server"></strong>
                </div>
                <br />
                <div class="pull-left">
                    <asp:LinkButton ID="password" runat="server" Text="Cambiar" ForeColor="Red" OnClick="password_Click"></asp:LinkButton>
                </div>
                <br />
                <div class="pull-left">
                    <strong id="correotxt" runat="server"></strong>
                </div>
                <br />
                <div class="pull-left">
                    <strong id="dirtxt" runat="server"></strong>
                </div>
                <div class="pull-left">
                    <strong id="telefonotxt" runat="server"></strong>
                </div>
                <br />
            </div>        
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
       
</asp:Content>

