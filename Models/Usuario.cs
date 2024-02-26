using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursosServitec.Models
{
    public class usuario
    {
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }


    }
}