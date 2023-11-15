using S14Lab_DA;
using S14Lab_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14Lab_BL
{
    public class AutoBL
    {
        private readonly AutoDA objAutoDA;
        public AutoBL()
        {
            objAutoDA = new AutoDA();
        }

        public string AgregarAuto(Auto auto)
        {
            return objAutoDA.AgregarAuto(auto);
        }

        //Eliminar un auto

        public string EliminarAuto(string Placa)
        {
            return objAutoDA.EliminarAuto(Placa);
        }

        //Modificar info de auto
        public string ModificarAuto(Auto auto)
        {
            return objAutoDA.ModificarAuto(auto);
        }

        //Listar Todos los Autos
        public List<Auto> ListarAutos()
        {
            return objAutoDA.ListarAutos();
        }
        //Listar segun marca
        public List<Auto> ListarAutosPorMarca(string marca)
        {
            return objAutoDA.ListarAutosPorMarca(marca);
        }
        //Listar segun año
        public List<Auto> ListarAutosPorFab(int fabYear)
        {
            return objAutoDA.ListarAutosPorFab(fabYear);
        }
        //Listar segun año y marca
        public List<Auto> ListarAutosPorMarcaYFab(string marca, int fabYear)
        {
            return objAutoDA.ListarAutosPorMarcaYFab(marca, fabYear);
        }
    }
}
