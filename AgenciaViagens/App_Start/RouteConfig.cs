using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AgenciaViagens
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Contato",
                url: "Contato",
                defaults: new { controller = "Home", action = "Contact" }
            );
            routes.MapRoute(
                name: "Criar_Conta",
                url: "Criar_Conta",
                defaults: new { controller = "Account", action = "Register" }
            );
            routes.MapRoute(
                name: "Login",
                url: "Login",
                defaults: new { controller = "Account", action = "Login" }
            );
            routes.MapRoute(
                name: "Minha_Conta",
                url: "Minha_Conta",
                defaults: new { controller = "Manage", action = "Index" }
            );
            routes.MapRoute(
                name: "Editar_Conta",
                url: "Editar_Conta",
                defaults: new { controller = "Manage", action = "Edit" }
            );
            routes.MapRoute(
                name: "Alterar_Senha",
                url: "Alterar_Senha",
                defaults: new { controller = "Manage", action = "ChangePassword" }
            );
            routes.MapRoute(
                name: "Minhas_Viagens",
                url: "Minhas_Viagens",
                defaults: new { controller = "Adquire", action = "Index" }
            );
            routes.MapRoute(
                name: "Minhas_Viagens_id",
                url: "Minhas_Viagens/{id}",
                defaults: new { controller = "Adquire", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Cancelar_Viagem",
                url: "Cancelar_Viagem/{id}",
                defaults: new { controller = "Adquire", action = "Delete", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Destinos",
                url: "Destinos",
                defaults: new { controller = "Destinos", action = "Index" }
            );
            routes.MapRoute(
                name: "Promocoes",
                url: "Promocoes",
                defaults: new { controller = "Promocoes", action = "Index" }
            );
            routes.MapRoute(
                name: "Viagens",
                url: "Viagens/{id}",
                defaults: new { controller = "Viagens", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Adquirir_Viagem",
                url: "Adquirir_Viagem/{id}",
                defaults: new { controller = "Adquire", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
