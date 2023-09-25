using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Ciudad : BaseEntity
    {
        public string Nombre { get; set; }
        public int IddepartamentoFk { get; set; }
        public Departamento Departamentos { get; set; }
    }
}