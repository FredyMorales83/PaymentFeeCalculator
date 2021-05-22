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
            porcentajeIVA = Properties.Settings.Default.TasaIVA;
        }

        private void btnPaypal_Click(object sender, EventArgs e)
        {
            var paypalFees = Fee.GetPaypalFees();
            SetProviderFees(paypalFees, sender, e, true);
        }

        private void btnSenorPago_Click(object sender, EventArgs e)
        {
            var senorPagoFees = Fee.GetSenorPagoFees();
            SetProviderFees(senorPagoFees, sender, e, true);
        }

        private void btnMercadoLibre_Click(object sender, EventArgs e)
        {
            var mercadoLibreFees = Fee.GetMercadoLibreFees();
            SetProviderFees(mercadoLibreFees, sender, e, false);
        }

        private void btnMercadoPago_Click(object sender, EventArgs e)
        {
            var mercadoPagoFees = Fee.GetMercadoPagoFees();
            SetProviderFees(mercadoPagoFees, sender, e, true);
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            var clipFees = Fee.GetClipFees();
            SetProviderFees(clipFees, sender, e, true);
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
                txtCantidadDeseada.Minimum = 500;

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
                txtCantidadDeseada.Minimum = 10;
            }

            decimal porcentajeComision = decimal.Parse(txtTarifaPorcentaje.Text) + comisionMeses;

            decimal tarifaFija = decimal.Parse(txtTarifaFija.Text);

            decimal iva = AplicaIVA ? (porcentajeIVA / 100) : 0;

            comisionAPagar = Fee.ReverseFeeCalculator(txtCantidadDeseada.Value, porcentajeComision, tarifaFija, iva);

            txtCantidadACobrar.Value = comisionAPagar;
            txtCantidadPagada.Value = comisionAPagar;
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

            decimal iva = AplicaIVA ? (porcentajeIVA / 100) : 0;

            comisionAPagar = Fee.FeeCalculator(txtCantidadPagada.Value, porcentajeComision, tarifaFija, iva);

            txtComisionAPagar.Value = comisionAPagar;

            txtCantidadARecibir.Value = txtCantidadPagada.Value - txtComisionAPagar.Value;
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

        private void btnSystemConfiguration_Click(object sender, EventArgs e)
        {
            frmConfiguration frmConfiguration = new frmConfiguration();

            frmConfiguration.ShowDialog();
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

        private void SetProviderFees((decimal providerPorciento, decimal providerFija, decimal provider3, decimal provider6, decimal provider9, decimal provider12, bool providerAplicaIVA) providerFees, object sender, EventArgs e, bool EnableMSI)
        {
            txtTarifaPorcentaje.Text = providerFees.providerPorciento.ToString();
            txtTarifaFija.Text = providerFees.providerFija.ToString();
            rbTresMSI.Text = $"3 MSI = {providerFees.provider3}%";
            rbTresMSI.Tag = providerFees.provider3;
            rbSeisMSI.Text = $"6 MSI = {providerFees.provider6}%";
            rbSeisMSI.Tag = providerFees.provider6;
            rbNueveMSI.Text = $"9 MSI = {providerFees.provider9}%";
            rbNueveMSI.Tag = providerFees.provider9;
            rbDoceMSI.Text = $"12 MSI = {providerFees.provider12}%";
            rbDoceMSI.Tag = providerFees.provider12;
            AplicaIVA = providerFees.providerAplicaIVA;
            cbMSI.Enabled = EnableMSI;
            txtCantidadPagada_ValueChanged(sender, e);
            txtCantidadDeseada_ValueChanged(sender, e);
        }

    }
}
