using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Web.Models
{
    public class Persona
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Celular Celular { get; set; }
    }
}
