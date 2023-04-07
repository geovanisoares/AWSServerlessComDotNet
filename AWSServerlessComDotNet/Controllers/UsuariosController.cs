using AWSServerlessComDotNet.Model;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerlessComDotNet.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        [HttpGet]
        public string Index()
        {

            return Usuarios.retornaUsuarios();
        }
    }
}
