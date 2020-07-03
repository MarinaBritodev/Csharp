using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace formulario.Models
{
    public class Registro
    {
        [Key]
        public int Codigo { get; set; }
        public int Identificador { get; set; }
        public float Volume { get; set; }
        public float Frete { get; set; }
        public string Placa { get; set; }
        public int Capacidade { get; set; }
    }
}