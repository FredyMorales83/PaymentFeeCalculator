using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentFeeCalculator
{
    public partial class frmMain : Form
    {
        //TODO
        //Crear formulario de configuracion de porcentajes de comision por proveedor para ser leidos archivo de configuracion

        //Leer porcentaje de IVA desde archivo de configuracion
        private decimal comisionAPagar, porcentajeIVA = 0;
        bool AplicaIVA = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelMSI.Enabled = false;
        }

        private void btnPaypal_Click(object sender, EventArgs e)
        {
            txtTarifaPorcentaje.Text = "3.95";
            txtTarifaFija.Text = "4";
            rbTresMSI.Text = "3 MSI = 4.55%";
            rbTresMSI.Tag = "4.55";
            rbSeisMSI.Text = "6 MSI = 7.25%";
            rbSeisMSI.Tag = "7.25";
            rbNueveMSI.Text = "9 MSI = 11.25%";
            rbNueveMSI.Tag = "11.25";
            rbDoceMSI.Text = "12 MSI = 13.5%";
            rbDoceMSI.Tag = "13.5";
            cbMSI.Enabled = true;
            AplicaIVA = true;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void btnSenorPago_Click(object sender, EventArgs e)
        {
            txtTarifaPorcentaje.Text = "3.6";
            txtTarifaFija.Text = "0";
            rbTresMSI.Text = "3 MSI = 3%";
            rbTresMSI.Tag = "3";
            rbSeisMSI.Text = "6 MSI = 6%";
            rbSeisMSI.Tag = "6";
            rbNueveMSI.Text = "9 MSI = 9%";
            rbNueveMSI.Tag = "9";
            rbDoceMSI.Text = "12 MSI = 12%";
            rbDoceMSI.Tag = "12";
            cbMSI.Enabled = true;
            AplicaIVA = true;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void btnMercadoLibre_Click(object sender, EventArgs e)
        {
            txtTarifaPorcentaje.Text = "17.5";
            txtTarifaFija.Text = "0";
            rbTresMSI.Text = "3 MSI = N/A";
            rbTresMSI.Tag = "0";
            rbSeisMSI.Text = "6 MSI = N/A";
            rbSeisMSI.Tag = "0";
            rbNueveMSI.Text = "9 MSI = N/A";
            rbNueveMSI.Tag = "0";
            rbDoceMSI.Text = "12 MSI = N/A";
            rbDoceMSI.Tag = "0";
            cbMSI.Enabled = false;
            AplicaIVA = false;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void btnMercadoPago_Click(object sender, EventArgs e)
        {
            txtTarifaPorcentaje.Text = "3.19";
            txtTarifaFija.Text = "4";
            rbTresMSI.Text = "3 MSI = 3.97%";
            rbTresMSI.Tag = "3.97";
            rbSeisMSI.Text = "6 MSI = 6.47%";
            rbSeisMSI.Tag = "6.47";
            rbNueveMSI.Text = "9 MSI = 9.24%";
            rbNueveMSI.Tag = "9.24";
            rbDoceMSI.Text = "12 MSI = 12.31%";
            rbDoceMSI.Tag = "12.31";
            cbMSI.Enabled = true;
            AplicaIVA = true;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            txtTarifaPorcentaje.Text = "3.6";
            txtTarifaFija.Text = "0";
            rbTresMSI.Text = "3 MSI = 4.5%";
            rbTresMSI.Tag = "4.5";
            rbSeisMSI.Text = "6 MSI = 7.5%";
            rbSeisMSI.Tag = "7.5";
            rbNueveMSI.Text = "9 MSI = 9.9%";
            rbNueveMSI.Tag = "9.9";
            rbDoceMSI.Text = "12 MSI = 11.95%";
            rbDoceMSI.Tag = "11.95";
            cbMSI.Enabled = true;
            AplicaIVA = true;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void cbMSI_CheckedChanged(object sender, EventArgs e)
        {
            panelMSI.Enabled = cbMSI.Checked ? true : false;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void txtCantidadDeseada_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTarifaPorcentaje.Text))
            {
                MessageBox.Show("Debe ingresar el porcentaje de comision cobrada por el proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal comisionMeses = 0;

            if (cbMSI.Checked)
            {
                txtCantidadDeseada.Minimum = 400;

                if (rbTresMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbTresMSI.Tag.ToString());
                }

                if (rbSeisMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbSeisMSI.Tag.ToString());
                }

                if (rbNueveMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbNueveMSI.Tag.ToString());
                }

                if (rbDoceMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbDoceMSI.Tag.ToString());
                }
            }
            else
            {
                comisionMeses = 0;
            }

            decimal porcentajeComision = decimal.Parse(txtTarifaPorcentaje.Text) + comisionMeses;

            decimal tarifaFija = decimal.Parse(txtTarifaFija.Text);

            decimal iva = AplicaIVA ? (porcentajeIVA = 16m / 100) : 0;

            comisionAPagar = ReverseFeeCalculator(txtCantidadDeseada.Value, porcentajeComision, tarifaFija, iva);

            txtCantidadACobrar.Value = comisionAPagar;
            txtCantidadPagada.Value = comisionAPagar;
        }

        private decimal ReverseFeeCalculator(decimal value, decimal porcentajeComision, decimal tarifaFija, decimal iva)
        {
            return (value + tarifaFija * (1 + iva)) / (1 - porcentajeComision * (1 + iva) / 100);
        }

        private void txtCantidadPagada_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTarifaPorcentaje.Text))
            {
                MessageBox.Show("Debe ingresar el porcentaje de comision cobrada por el proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal comisionMeses = 0;

            if (cbMSI.Checked)
            {
                if (rbTresMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbTresMSI.Tag.ToString());
                }

                if (rbSeisMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbSeisMSI.Tag.ToString());
                }

                if (rbNueveMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbNueveMSI.Tag.ToString());
                }

                if (rbDoceMSI.Checked)
                {
                    comisionMeses = decimal.Parse(rbDoceMSI.Tag.ToString());
                }
            }
            else
            {
                comisionMeses = 0;
            }

            decimal porcentajeComision = decimal.Parse(txtTarifaPorcentaje.Text) + comisionMeses;
            decimal tarifaFija = decimal.Parse(txtTarifaFija.Text);

            decimal iva = AplicaIVA ? (porcentajeIVA = 16m / 100) : 0;

            comisionAPagar = FeeCalculator(txtCantidadPagada.Value, porcentajeComision, tarifaFija, iva);

            txtComisionAPagar.Value = comisionAPagar;

            txtCantidadARecibir.Value = txtCantidadPagada.Value - txtComisionAPagar.Value;
        }

        private decimal FeeCalculator(decimal value, decimal porcentajeComision, decimal tarifaFija, decimal iva)
        {
            return value * ((porcentajeComision / 100) * (1 + iva)) + tarifaFija * (1 + iva);
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }
    }
}
