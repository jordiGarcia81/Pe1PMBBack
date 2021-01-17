using PlaceMyBetOficial.Models;
using PlaceMyBetOficial.Models.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBetOficial.Controllers
{
    [RoutePrefix("api/Usuarios")]
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        /// <summary>
        /// metodo que devuelve lista de usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        [Route("GetUsuarios"), HttpGet]
        public List<Usuario> GetUsuarios()
        {
            UsuarioRepository userrepo = new UsuarioRepository();
            List<Usuario> usuarios = userrepo.GetUsuarios();
            return usuarios;
        }

        [Route("DeleteUsuarios"), HttpDelete]
        public void Delete(string id)
        {
            UsuarioRepository rep = new UsuarioRepository();
            rep.Delete(id);
        }

        //[Route("api/GetUsuarioDTO")]
        //[HttpPost]
        //public List<UsuarioDTO> GetUsuarioDTO()
        //{
        //    UsuarioRepository usuarioRepository = new UsuarioRepository();
        //    List<UsuarioDTO> usuarios = usuarioRepository.GetUsuarioDTO();
        //    return usuarios;
        //}
        //[Route("FilterUsuarios"), HttpGet]
        //public List<Usuario> Filter(string searchString)
        //{
        //    UsuarioRepository usuarioRepository = new UsuarioRepository();
        //    List<Usuario> usuarios = usuarioRepository.FilterUsers(searchString);
        //    return usuarios;
        //}
        [Route("GetUsuarioNombre"), HttpGet]
        public Usuario GetUsuarioNombre(string nombre)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            Usuario usuario = usuarioRepository.GetUsuarioNombre(nombre);
            return usuario;
        }
        [Route("GetUsuarioApellido"), HttpGet]
        public Usuario GetUsuarioApellido(string apellido)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            Usuario usuario = usuarioRepository.GetUsuarioNombre(apellido);
            return usuario;
        }
        [Route("GetUsuarioEmail"), HttpGet]
        public Usuario GetUsuarioEmail(string email)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            Usuario usuario = usuarioRepository.GetUsuarioNombre(email);
            return usuario;
        }
    }
}
