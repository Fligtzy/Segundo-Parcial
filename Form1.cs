using System;
using System.Windows.Forms;

namespace Examen_RentaCar_SuNombre
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Now;
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            rbtSucursal.Checked = true;
            lstAlquileres.Items.Clear();
            subtotal = 0;
            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEncabezado.Text = "Días".PadRight(6) + "Vehículo".PadRight(24)
                               + "Tarifa".PadLeft(10) + "Total".PadLeft(12);
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal tarifa;
            if (txtVehiculo.Text.Trim() == "" || !decimal.TryParse(txtTarifa.Text, out tarifa))
            {
                MessageBox.Show("Digite el vehículo y una tarifa válida.");
                return;
            }

            string detalle = "";
            if (rbtCompleto.Checked) { tarifa += 300; detalle = "Completo"; }
            if (chkGps.Checked)
            {
                tarifa += 100;
                detalle += (detalle == "" ? "" : " + ") + "GPS";
            }

            int dias = (int)nudDias.Value;
            decimal total = tarifa * dias;
            subtotal += total;

            string nombre = txtVehiculo.Text.Trim();
            if (detalle != "") nombre += " (" + detalle + ")";

            lstAlquileres.Items.Add(dias.ToString().PadRight(6) + nombre.PadRight(24)
                                  + tarifa.ToString("N2").PadLeft(10)
                                  + total.ToString("N2").PadLeft(12));

            // reiniciar controles del vehículo
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un vehículo.");
                return;
            }

            decimal descuento = chkCorporativo.Checked ? subtotal * 0.15m : 0;
            decimal domicilio = rbtDomicilio.Checked ? 500 : 0;
            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * 0.18m;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = "RD$ " + subtotal.ToString("N2");
            lblDescuento.Text = "RD$ " + descuento.ToString("N2");
            lblDomicilio.Text = "RD$ " + domicilio.ToString("N2");
            lblItbis.Text = "RD$ " + itbis.ToString("N2");
            lblTotal.Text = "RD$ " + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
