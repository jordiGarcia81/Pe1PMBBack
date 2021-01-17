using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetOficial.Models.objects
{
    public class Usuario
    {
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public List<Apuesta> Apuestas { get; set; }
        public Cuenta Cuenta { get; set; }

        public Usuario(string usuarioId, string nombre, string apellidos, int edad)
        {
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
        }

    }

    public class UsuarioDTO
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string UsuarioId { get; set; }

        public UsuarioDTO()
        {

        }
        public UsuarioDTO(string nombre, string apellidos,string usuarioId)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.UsuarioId = usuarioId;


        }


    }
}