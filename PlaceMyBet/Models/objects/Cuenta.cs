using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBetOficial.Models.objects
{
    public class Cuenta
    {

    public long CuentaId { get; set; }
    public string NombreBanco { get; set; }
    public int Saldo { get; set; }
    public string UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(long cuentaId, string nombreBanco, int saldo, string usuarioId)
        {
            this.CuentaId = cuentaId;
            this.NombreBanco = nombreBanco;
            this.Saldo = saldo;
            this.UsuarioId = usuarioId;
        }

        
    }
}