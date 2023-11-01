using Api.ADAproductosComun.Comun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ADAproductosComun.Comun
{
    public class Retorno<T>
    {
        public Retorno() { }

        public bool Estado { get; set; }

        public T Informacion { get; set;}

        public GeneralEnum.TipoRetorno TipoRetorno { get; set; }

        public DateTime FechaConsulta { get; set; }

        public List<String> Mensaje { get; set; }



    }
}
