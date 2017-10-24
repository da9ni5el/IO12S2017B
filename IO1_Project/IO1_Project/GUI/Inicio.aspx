<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="IO1_Project.GUI.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--Carrusel de imagenes comentado.--%> 
    <%--  
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
          <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
          </ol>
          <div class="carousel-inner" role="listbox">
            <div class="carousel-item active">                
              <a title="probando esta mierda" href="http://www.youtube.com"><img class="d-block img-fluid w-100" src="../imagenes carousel/w1IvP.jpg" alt="">
              <div class="carousel-caption d-none d-md-block">
                <h3 class="text-shadow">First Slide</h3>
                <p class="text-shadow">This is the caption for the first slide.</p>
              </div>
            </div>
            <div class="carousel-item">
              <img class="d-block img-fluid w-100" src="../imagenes carousel/abc_promocion_cine_clasico_cada_sabado_por_1_99_euros_los_diez_mandamientos_titulos_dvd_peliculas.jpg" alt="">
              <div class="carousel-caption d-none d-md-block">
                <h3 class="text-shadow">Second Slide</h3>
                <p class="text-shadow">This is the caption for the second slide.</p>
              </div>
            </div>
            <div class="carousel-item">
              <img class="d-block img-fluid w-100" src="../imagenes carousel/descarga.jpg" alt="">
              <div class="carousel-caption d-none d-md-block">
                <h3 class="text-shadow">Third Slide</h3>
                <p class="text-shadow">This is the caption for the third slide.</p>
              </div>
            </div>
          </div>
          <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
          </a>
          <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
          </a>
        </div>
      --%>

    <div class="jumbotron">
        <div class="container text-center">
            <h1><strong>Titulos Destacados</strong></h1>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">



    <div class="row">
        <div class="col-sm-3">
            <h4><strong>categorias</strong></h4>
            <br />
            aqui el listado de categorias. 
        </div>
        <div class="col-sm-9">
            <p class="alert-light">Mas vendidas</p>
            <div class="container">
                <div class="row">
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                <a href="Pelicula.aspx">
                                    <asp:Image ID="Image1" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                                </a>
                            </div>

                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                 <asp:Image ID="Image2" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                <asp:Image ID="Image3" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                </div>
            </div>
            <br>
            <p class="alert-light">Mas Populares</p>
            <div class="container">
                <div class="row">
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                <asp:Image ID="Image4" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                 <asp:Image ID="Image5" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                 <asp:Image ID="Image6" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                </div>
            </div>
            <br />

            <p class="alert-light">Mejor Votadas</p>
            <div class="container">
                <div class="row">
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                 <asp:Image ID="Image7" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                <asp:Image ID="Image8" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer" id="divdescripcion" runat="server">Descripcion</div>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="panel panel-primary">
                            <div class="panel-heading">Titulo</div>
                            <div class="panel-body">
                                 <asp:Image ID="Image9" runat="server" CssClass="img-responsive" AlternateText="Image" Width="230px" Height="200px" ImageUrl="https://placehold.it/150x80?text=IMAGE" />
                            </div>
                            <div class="panel-footer">Descripcion</div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>

    <%--Esta parte debiera de llenarse automaticamente al cargar la pagina con la DB--%> 
    
</asp:Content>
<%-- Footer --%>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <p class="alert-info">
        Sitio web desarrollado ùnicamente con propositos educativos.
    </p>
</asp:Content>


<%-- Menu de la pagina --%>
 <asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">    
     <ul class="nav navbar-nav navbar-right">
        <li><a href="Carrito.aspx"><span class="glyphicon glyphicon-shopping-cart"></span>Carrito de Compra</a></li>

        <%
            
            if (currentrol == "0")
            {
                Response.Write("<li><a href=\"Configuracion_Cuenta.aspx\"><span class=\"glyphicon glyphicon-user\"></span>Mi Cuenta</a></li>");
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