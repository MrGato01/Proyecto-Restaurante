using Datos.Interfaces;
using Datos.Repositorios;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Modelos;
using System.Security.Claims;

namespace Blazor.Controllers
{
    public class LoginController : Controller
    {
      private readonly Config _config;
      private ILoginRepositorio _loginRepositorio;
      private IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(Config config)
        {
            _config = config;
            _loginRepositorio = new LoginRepositorio(config.CadenaConexion);
            _usuarioRepositorio = new UsuarioRepositorio(config.CadenaConexion);
        }

        [HttpPost("/autenticar/validar")]
        public async Task<IActionResult> Validacion(Login login)
        {
            string rol = string.Empty;

            try
            {
                bool usuarioValido = await _loginRepositorio.ValidarUsuarioAsync(login);

                if (usuarioValido)
                {
                    Usuario user = await _usuarioRepositorio.GetPorCodigoAsync(login.CodigoUsuario);

                    if (user.EstaActivo)
                    {
                        rol = user.Rol;

                        var claims = new[]
                        {
                            new Claim(ClaimTypes.Name, user.CodigoUsuario),
                            new Claim(ClaimTypes.Role, user.Rol)
                        };

                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties { IsPersistent = true, ExpiresUtc = DateTime.UtcNow.AddMinutes(15)});
                    }
                    else
                    {
                        return LocalRedirect("/Login/El usuario con el que tratas de iniciar sesion no se encuentra activo! :( ¡Ponte en contacto con un administrador!"); 
                    }
                }

                else
                {
                    return LocalRedirect("/Login/Los datos de usuario son incorrectos :(");
                }
            }
            catch (Exception)
            {
            }

           return LocalRedirect("/");
        }

        [HttpGet("/salir")]
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("/Login");
        }
    }
}
