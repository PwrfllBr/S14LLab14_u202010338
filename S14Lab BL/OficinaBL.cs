using S14Lab_DA;
using S14Lab_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14Lab_BL
{
    public class OficinaBL
    {
        private readonly OficinaDA objOficinaDA;
        public OficinaBL()
        {
            objOficinaDA = new OficinaDA();
        }
        public List<Oficina> ListarOficina()
        {
            return objOficinaDA.ListarOficina();
        }
    }
}
