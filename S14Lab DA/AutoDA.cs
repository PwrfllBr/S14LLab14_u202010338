using S14Lab_BE;
using S14Lab_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S14Lab_DA
{
    public class AutoDA
    {
        private readonly dbLab14Entities db;

        public AutoDA()
        {
            db = new dbLab14Entities();
        }

        //Verificar si el auto existe

        //Agregar un nuevo auto
        public string AgregarAuto(Auto auto)
        {
            try
            {
                var autoExistente = db.Autoes.FirstOrDefault(x => x.Placa == auto.Placa);
                if (autoExistente != null)
                {
                    return "Esta placa ya ha sido registrada en la base de datos";
                }
                db.Autoes.Add(auto);
                db.SaveChanges();
                return "Registro Existoso";
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Eliminar un auto

        public string EliminarAuto(string Placa)
        {
            db.SaveChanges();

            try
            {
                Auto autoTemp = db.Autoes.Find(Placa);
                db.Autoes.Remove(autoTemp);
                db.SaveChanges();
                return "Se ha eliminado el auto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Modificar info de auto
        public string ModificarAuto(Auto auto)
        {
            try
            {
                Auto autoTemp = db.Autoes.Find(auto.Placa);
                autoTemp.idOficina = auto.idOficina;
                autoTemp.Modelo = auto.Modelo;
                autoTemp.Marca = auto.Marca;
                autoTemp.nAsientos = auto.nAsientos;
                autoTemp.FabYear = auto.FabYear;
                db.SaveChanges();
                return "Actualizacion Existosa";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Listar Todos los Autos
        public List<Auto> ListarAutos()
        {
            List<Auto> autos = new List<Auto>();
            try
            {
                autos = db.Autoes.ToList();
                return autos;
            }
            catch (Exception ex)
            {
                return autos;
            }
        }
        //Listar segun marca
        public List<Auto> ListarAutosPorMarca(string marca)
        {
            List<Auto> autos = new List<Auto>();
            try
            {
                autos = db.Autoes.Where(x => x.Marca.Equals(marca)).ToList();
                return autos;
            }
            catch (Exception ex)
            {
                return autos;
            }
        }
        //Listar segun año
        public List<Auto> ListarAutosPorFab(int fabYear)
        {
            List<Auto> autos = new List<Auto>();
            try
            {
                autos = db.Autoes.Where(x => x.FabYear.Equals(fabYear)).ToList();
                return autos;
            }
            catch (Exception ex)
            {
                return autos;
            }
        }
        //Listar segun año y marca
        public List<Auto> ListarAutosPorMarcaYFab(string marca, int fabYear)
        {
            List<Auto> autos = new List<Auto>();
            try
            {
                autos = db.Autoes.Where(x => x.Marca.Equals(marca) && x.FabYear.Equals(fabYear)).ToList();
                return autos;
            }
            catch (Exception ex)
            {
                return autos;
            }
        }
    }
}
