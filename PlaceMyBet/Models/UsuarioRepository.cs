using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using PlaceMyBetOficial.Models.objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;


namespace PlaceMyBetOficial.Models
{
    public class UsuarioRepository
    {
        public List<Usuario> GetUsuarios()
        {

            List<Usuario> usuarios = new List<Usuario>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                // mercados = context.Mercados.Include(p => p.eventos).ToList();
                usuarios = context.Usuarios.ToList();
            }


            return usuarios;

        }


        internal void Delete(string id)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Usuario u;
            using (context)
            {
                u = context.Usuarios.Where(b => b.UsuarioId == id).FirstOrDefault();
                context.Usuarios.Remove(u);
                context.SaveChanges();
            }
        }

        internal List<UsuarioDTO> GetUsuarioDTO()
        {

            List<UsuarioDTO> usuarios = new List<UsuarioDTO>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                usuarios = context.Usuarios.Select(p => ToDTO(p)).ToList();
                Debug.WriteLine("usuarios" + usuarios.Count);
            }

            return usuarios;
        }

        static UsuarioDTO ToDTO(Usuario u)
        {
            return new UsuarioDTO(u.Nombre, u.Apellidos, u.UsuarioId);
        }

        //public List<Usuario> FilterUsers( string searchString)
        //{
        //    List<Usuario> usuarios = new List<Usuario>();
        //   // List<UsuarioDTO> usuarioDTO = new List<UsuarioDTO>;
        //    using (PlaceMyBetContext context = new PlaceMyBetContext())
        //    {
        //        if (!String.IsNullOrEmpty(searchString))
        //        {
        //            usuarios = (List<Usuario>)usuarios.Where(s => s.Nombre.Contains(searchString) || s.Apellidos.Contains(searchString) || s.UsuarioId.Contains(searchString));

        //        }

        //    }

        //    return usuarios;
        //}

        internal Usuario GetUsuarioNombre(string nombre)
        {
            Usuario usuario;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                usuario = context.Usuarios
                     .Where(s => s.Nombre == nombre)
                     .FirstOrDefault();
            }
            return usuario;

        }

        internal Usuario GetUsuarioApellido(string apellido)
        {
            Usuario usuario;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                usuario = context.Usuarios
                     .Where(s => s.Apellidos == apellido)
                     .FirstOrDefault();
            }
            return usuario;

        }

        internal Usuario GetUsuarioEmail(string email)
        {
            Usuario usuario;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                usuario = context.Usuarios
                     .Where(s => s.UsuarioId == email)
                     .FirstOrDefault();
            }
            return usuario;

        }
    }
}