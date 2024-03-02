using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5.Utilidades
{
    internal class ConexionBDParam
    {
        public ConexionBDParam() { }

        //El Json debe llevar las claves con estos nombres exactamente
        public string dataSource { get; set; }
        public string initialCatalog { get; set; }
        public bool encrypt { get; set; }
        public bool integratedSecurity { get; set; }

        public string toString()
        {
            return string.Format("Data Source={0};Initial Catalog={1};Encrypt={2};Integrated Security={3}", dataSource, initialCatalog, encrypt, integratedSecurity);
        }
    }
}
