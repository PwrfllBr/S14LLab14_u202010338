using S14Lab_BL;
using S14Lab_EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S14LLab14_u202010338
{
    public partial class FormAutos : Form
    {
        private AutoBL autoBL = new AutoBL();
        private OficinaBL oficinaBL = new OficinaBL();
        private Auto autoSeleccionado = null;
        public FormAutos()
        {
            InitializeComponent();
            CargarLista(autoBL.ListarAutos());
            //Carga el combobox de nAsientos
            for(int i = 2; i<=8; i++) { cbNAsientos.Items.Add(i.ToString()); }
            //Carga el combobox de ID Oficinas
            CargarCBOficina();
            LimpiarCeldas();
        }
        private void CargarCBOficina()
        {
            List<Oficina> oficinas = new List<Oficina>();
            oficinas = oficinaBL.ListarOficina();
            foreach (Oficina oficina in oficinas) { cbIDOficina.Items.Add(oficina.idOficina.ToString()); }
        }
        private void CargarLista(List<Auto> autos)
        {
            dgvListaAutos.DataSource = autos;
            dgvListaAutos.Columns["Oficina"].Visible = false;
            dgvListaAutos.Columns["idOficina"].HeaderText = "ID de la Oficina";
            dgvListaAutos.Columns["nAsientos"].HeaderText = "# de Asientos";
            dgvListaAutos.Columns["FabYear"].HeaderText = "Año de Fabricación";
        }
        private void LimpiarCeldas()
        {
            txtPlaca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtFabYear.Text = string.Empty;
            cbIDOficina.Text = string.Empty;
            cbNAsientos.Text = string.Empty;
            autoSeleccionado = null;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validar campos
            if(txtPlaca.Text == "" || txtModelo.Text == "" || txtMarca.Text == "" || txtFabYear.Text == "" ||
                cbIDOficina.Text == "" || cbNAsientos.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            //Crear Auto
            Auto auto = new Auto
            {
                idOficina = int.Parse(cbIDOficina.Text),
                Placa = txtPlaca.Text.ToUpper(),
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                nAsientos = int.Parse(cbNAsientos.Text),
                FabYear = int.Parse(txtFabYear.Text),
            };
            //Registrar Auto
            string mensaje = autoBL.AgregarAuto(auto);
            MessageBox.Show(mensaje);
            //Actualizar Tabla
            LimpiarCeldas();
            CargarLista(autoBL.ListarAutos());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Validar seleccion
            if (autoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un auto antes de eliminar");
                return;
            }
            //Eliminar auto
            string mensaje = autoBL.EliminarAuto(autoSeleccionado.Placa);
            MessageBox.Show(mensaje);
            //Actualizar Tabla
            LimpiarCeldas();
            CargarLista(autoBL.ListarAutos());
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtFabYearFiltro.Text == "" && txtMarcaFiltro.Text == "")
            { //Si no ingresas ningun filtro
                MessageBox.Show("Seleccione al menos un campo de filtro");
            } else if (txtFabYearFiltro.Text != "" && txtMarcaFiltro.Text == "")
            { //si solo ingresas marca
                CargarLista(autoBL.ListarAutosPorFab(int.Parse(txtFabYearFiltro.Text)));
            } else if(txtFabYearFiltro.Text == "" && txtMarcaFiltro.Text != "")
            { //si solo ingresas fabricacion
                CargarLista(autoBL.ListarAutosPorMarca(txtMarcaFiltro.Text));
            }
            else //si ingresas ambos
            {
                CargarLista(autoBL.ListarAutosPorMarcaYFab(txtMarcaFiltro.Text, int.Parse(txtFabYearFiltro.Text)));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvListaAutos_DoubleClick(object sender, EventArgs e)
        {
            List<Auto> ListaAutos = new List<Auto>();
            ListaAutos = autoBL.ListarAutos();
            if (dgvListaAutos.CurrentCell.RowIndex != -1)
            {
                //anotar auto seleccionado
                string PlacaSelect = dgvListaAutos.CurrentRow.Cells["Placa"].Value.ToString();
                autoSeleccionado = ListaAutos.Where(x => x.Placa == PlacaSelect).FirstOrDefault();
                //mostrar datos del auto seleccionado para poder editar
                txtPlaca.Text = autoSeleccionado.Placa;
                txtModelo.Text = autoSeleccionado.Modelo;
                txtMarca.Text = autoSeleccionado.Marca;
                txtFabYear.Text = autoSeleccionado.FabYear.ToString();
                cbIDOficina.Text = autoSeleccionado.idOficina.ToString();
                cbNAsientos.Text = autoSeleccionado.nAsientos.ToString();
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }
        private void btnMostrarListaCompleta_Click(object sender, EventArgs e)
        {
            txtFabYearFiltro.Text = txtMarcaFiltro.Text = string.Empty;
            CargarLista(autoBL.ListarAutos());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Validar campos
            if (txtPlaca.Text == "" || txtModelo.Text == "" || txtMarca.Text == "" || txtFabYear.Text == "" ||
                cbIDOficina.Text == "" || cbNAsientos.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            //actualizar datos del Auto seleccionado
            Auto auto = new Auto
            {
                idOficina = int.Parse(cbIDOficina.Text),
                Placa = txtPlaca.Text.ToUpper(),
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                nAsientos = int.Parse(cbNAsientos.Text),
                FabYear = int.Parse(txtFabYear.Text),
            };

            //Actualizar Auto
            string mensaje = autoBL.ModificarAuto(auto);
            MessageBox.Show(mensaje);
            //Actualizar Tabla
            LimpiarCeldas();
            CargarLista(autoBL.ListarAutos());
        }
    }
}
