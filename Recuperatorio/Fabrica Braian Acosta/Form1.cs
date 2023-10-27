using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Fabrica_Braian_Acosta
{
    public partial class FrmView : Form
    {
        private Fabrica fabrica;

        public FrmView()
        {
            InitializeComponent();
            InicializarFabrica();
            Refrescar();
        }

        private void InicializarFabrica()
        {
            fabrica = new Fabrica(5);
            Camioneta camioneta = new Camioneta(EPropulsion.Electrica, true);
            fabrica += camioneta;
        }

        /// <summary>
        /// Realiza las siguientes acciones:
        /// 1. Asigna al DataSource del lstVehiculos un null.
        /// 2. Asigna al DataSource del lstVehiculos la lista de vehículos de la fábrica.
        /// </summary>
        private void Refrescar()
        {
            lstVehiculos.DataSource = null;
            lstVehiculos.DataSource = fabrica.Vehiculos;
        }

        private Vehiculo CrearVehiculo()
        {
            if (cmbTipo.SelectedItem != null)
            {
                string tipoSeleccionado = cmbTipo.SelectedItem.ToString();
                if (tipoSeleccionado == "Automovil")
                {
                    return new Automovil();
                }
                else if (tipoSeleccionado == "Camioneta")
                {
                    return new Camioneta(EPropulsion.Hibrida, true);
                }
                else if (tipoSeleccionado == "Moto")
                {
                    return new Moto(EPropulsion.Combustion);
                }
            }
            return null;
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = CrearVehiculo();
            if (nuevoVehiculo is not null)
            {
                fabrica += nuevoVehiculo;
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItem != null)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)lstVehiculos.SelectedItem;
                fabrica -= vehiculoSeleccionado;
                Refrescar();
            }
        }

        private void FrmView_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
Nombre de clase: 
FrmView
Campos:
btnEliminar : Button
btnFabricar : Button
cmbTipo : ComboBox
components : IContainer
fabrica : Fabrica
lblTipo : Label
lstVehiculos : ListBox
pcbFabrica : PictureBox
Metodos:
private void btnEliminar_Click(object sender, EventArgs e)
private void btnFabricar_Click(object sender, EventArgs e)
private Vehiculo CrearVehiculo()
protected void Dispose(bool disposing)
public FrmView()
private void FrmView_Load(object sender, EventArgs e)
private void InicializarFabrica()
private void InitializeComponent()
private void Refrescar()
*/