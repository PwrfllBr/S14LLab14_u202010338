using S14Lab_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14Lab_DA
{
    public class OficinaDA
    {
        private readonly dbLab14Entities db;
        public OficinaDA()
        {
            db = new dbLab14Entities();
        }
        public List<Oficina> ListarOficina()
        {
            List<Oficina> oficinas = new List<Oficina>();
            try
            {
                oficinas = db.Oficinas.ToList();
                return oficinas;
            }
            catch (Exception ex)
            {
                return oficinas;
            }
        }
    }
}
