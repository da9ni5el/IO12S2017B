<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Master.Master" AutoEventWireup="true" CodeBehind="Pelicula.aspx.cs" Inherits="IO1_Project.GUI.Pelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <%--Aqui se mostrara imagen de la pelicula  --%>
   <div class="jumbotron">
        <div class="container text-center">
            <h1><strong id="titulo" runat="server">Nombre de la pelicula :v</strong></h1>

        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <asp:Image ID="Image1" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" Width="250px" Height="400px" />
            <br />
             
            <strong id="actores" runat="server">
                <span class="glyphicon glyphicon-bullhorn"></span> Peter Jackson
                 <span class="glyphicon glyphicon-star"></span> Ian Mckeller 
            </strong>
        </div>
        <div class="col-sm-8" id="container" runat="server">
            <h2><strong>Trailer de la pelicula</strong></h2><br />
        </div>        
    </div>
    <div class="text-center">
        <h2><strong>Sinopsis:</strong></h2>
        <p id="sinopsis" runat="server" class="text-info py-md-4">

        </p>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">        
    <div class="form-group">
        <label for="comment">Comentario:</label>
        <%--<textarea class="form-control" rows="5" id="comment"></textarea>--%>
        <asp:TextBox ID="TextBox1" runat="server" Rows="5" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="pull-right">
        <asp:Button ID="enviar"  CssClass="btn btn-primary" runat="server" Text="Enviar"/>
    </div>
        
    Esta parte solo se mostrara si existen comentarios. 
    <div class="media" id="coment" runat="server">
        <div class="media-left">
            <img src="../imagenes carousel/avatar.jpg" class="media-object" style="width: 60px">
        </div>
        <div class="media-body" style="width:100px; height:100px; overflow-y:scroll">
            <h4 class="media-heading">Un usuario cualquiera</h4>
            <p>
                Dejar aqui el comentario.                              
            </p>
           
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
 
</asp:Content>

<asp:Content ID="content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <ul class="nav navbar-nav navbar-right">
        <li><a href="#"><span class="glyphicon glyphicon-shopping-cart"></span>Carrito de Compra</a></li>


        <%
            string rol = Request.QueryString["rl"];
            if (rol == "0")
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
    </ul>    

</asp:Content>
