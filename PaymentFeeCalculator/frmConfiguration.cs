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
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            SaveFeeConfiguration();
        }

        private void SaveFeeConfiguration()
        {
            Properties.Settings.Default.TasaIVA = nudTasaIVA.Value;

            Properties.Settings.Default.PaypalPorciento = nudPaypalPorciento.Value;
            Properties.Settings.Default.PaypalFija = nudPaypalFija.Value;
            Properties.Settings.Default.Paypal3MSI = nudPaypal3MSI.Value;
            Properties.Settings.Default.Paypal6MSI = nudPaypal6MSI.Value;
            Properties.Settings.Default.Paypal9MSI = nudPaypal9MSI.Value;
            Properties.Settings.Default.Paypal12MSI = nudPaypal12MSI.Value;
            Properties.Settings.Default.PaypalAplicaIVA = cbPaypalIVA.Checked;

            Properties.Settings.Default.SenorPorciento = nudSenorPorciento.Value;
            Properties.Settings.Default.SenorFija = nudSenorFija.Value;
            Properties.Settings.Default.Senor3MSI = nudSenor3MSI.Value;
            Properties.Settings.Default.Senor6MSI = nudSenor6MSI.Value;
            Properties.Settings.Default.Senor9MSI = nudSenor9MSI.Value;
            Properties.Settings.Default.Senor12MSI = nudSenor12MSI.Value;
            Properties.Settings.Default.SenorAplicaIVA = cbSenorIVA.Checked;

            Properties.Settings.Default.MercadolibrePorciento = nudMercadolibrePorciento.Value;
            Properties.Settings.Default.MercadolibreFija = nudMercadolibreFija.Value;
            Properties.Settings.Default.Mercadolibre3MSI = nudMercadolibre3MSI.Value;
            Properties.Settings.Default.Mercadolibre6MSI = nudMercadolibre6MSI.Value;
            Properties.Settings.Default.Mercadolibre9MSI = nudMercadolibre9MSI.Value;
            Properties.Settings.Default.Mercadolibre12MSI = nudMercadolibre12MSI.Value;
            Properties.Settings.Default.MercadolibreAplicaIVA = cbMercadolibreIVA.Checked;

            nudMercadopagoPorciento.Value = Properties.Settings.Default.MercadopagoPorciento;
            Properties.Settings.Default.MercadopagoFija = nudMercadopagoFija.Value;
            Properties.Settings.Default.Mercadopago3MSI = nudMercadopago3MSI.Value;
            Properties.Settings.Default.Mercadopago6MSI = nudMercadopago6MSI.Value;
            Properties.Settings.Default.Mercadopago9MSI = nudMercadopago9MSI.Value;
            Properties.Settings.Default.Mercadopago12MSI = nudMercadopago12MSI.Value;
            Properties.Settings.Default.MercadopagoAplicaIVA = cbMercadopagoIVA.Checked;

            Properties.Settings.Default.ClipPorciento = nudClipPorciento.Value;
            Properties.Settings.Default.ClipFija = nudClipFija.Value;
            Properties.Settings.Default.Clip3MSI = nudClip3MSI.Value;
            Properties.Settings.Default.Clip6MSI = nudClip6MSI.Value;
            Properties.Settings.Default.Clip9MSI = nudClip9MSI.Value;
            Properties.Settings.Default.Clip12MSI = nudClip12MSI.Value;
            Properties.Settings.Default.ClipAplicaIVA = cbClipIVA.Checked;

            Properties.Settings.Default.Save();
            MessageBox.Show("Configuracion guardada satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            ReadFeeConfiguration();
        }

        private void ReadFeeConfiguration()
        {
            nudTasaIVA.Value = Properties.Settings.Default.TasaIVA;

            nudPaypalPorciento.Value = Properties.Settings.Default.PaypalPorciento;
            nudPaypalFija.Value = Properties.Settings.Default.PaypalFija;
            nudPaypal3MSI.Value = Properties.Settings.Default.Paypal3MSI;
            nudPaypal6MSI.Value = Properties.Settings.Default.Paypal6MSI;
            nudPaypal9MSI.Value = Properties.Settings.Default.Paypal9MSI;
            nudPaypal12MSI.Value = Properties.Settings.Default.Paypal12MSI;
            cbPaypalIVA.Checked = Properties.Settings.Default.PaypalAplicaIVA;

            nudSenorPorciento.Value = Properties.Settings.Default.SenorPorciento;
            nudSenorFija.Value = Properties.Settings.Default.SenorFija;
            nudSenor3MSI.Value = Properties.Settings.Default.Senor3MSI;
            nudSenor6MSI.Value = Properties.Settings.Default.Senor6MSI;
            nudSenor9MSI.Value = Properties.Settings.Default.Senor9MSI;
            nudSenor12MSI.Value = Properties.Settings.Default.Senor12MSI;
            cbSenorIVA.Checked = Properties.Settings.Default.SenorAplicaIVA;

            nudMercadolibrePorciento.Value = Properties.Settings.Default.MercadolibrePorciento;
            nudMercadolibreFija.Value = Properties.Settings.Default.MercadopagoFija;
            nudMercadolibre3MSI.Value = Properties.Settings.Default.Mercadopago3MSI;
            nudMercadolibre6MSI.Value = Properties.Settings.Default.Mercadopago6MSI;
            nudMercadolibre9MSI.Value = Properties.Settings.Default.Mercadopago9MSI;
            nudMercadolibre12MSI.Value = Properties.Settings.Default.Mercadopago12MSI;
            cbMercadolibreIVA.Checked = Properties.Settings.Default.MercadopagoAplicaIVA;

            nudMercadopagoPorciento.Value = Properties.Settings.Default.MercadopagoPorciento;
            nudMercadopagoFija.Value = Properties.Settings.Default.MercadopagoFija;
            nudMercadopago3MSI.Value = Properties.Settings.Default.Mercadopago3MSI;
            nudMercadopago6MSI.Value = Properties.Settings.Default.Mercadopago6MSI;
            nudMercadopago9MSI.Value = Properties.Settings.Default.Mercadopago9MSI;
            nudMercadopago12MSI.Value = Properties.Settings.Default.Mercadopago12MSI;
            cbMercadopagoIVA.Checked = Properties.Settings.Default.MercadopagoAplicaIVA;

            nudClipPorciento.Value = Properties.Settings.Default.ClipPorciento;
            nudClipFija.Value = Properties.Settings.Default.ClipFija;
            nudClip3MSI.Value = Properties.Settings.Default.Clip3MSI;
            nudClip6MSI.Value = Properties.Settings.Default.Clip6MSI;
            nudClip9MSI.Value = Properties.Settings.Default.Clip9MSI;
            nudClip12MSI.Value = Properties.Settings.Default.Clip12MSI;
            cbClipIVA.Checked = Properties.Settings.Default.ClipAplicaIVA;
        }

        public (decimal PaypalPorciento, decimal PaypalFija, decimal Paypal3, decimal Paypal6, 
            decimal Paypal9, decimal Paypal12, bool PaypalIVA) GetPaypalFees()
        {

            return (
                Properties.Settings.Default.PaypalPorciento,
                Properties.Settings.Default.PaypalFija,
                Properties.Settings.Default.Paypal3MSI,
                Properties.Settings.Default.Paypal6MSI,
                Properties.Settings.Default.Paypal9MSI,
                Properties.Settings.Default.Paypal12MSI,
                Properties.Settings.Default.PaypalAplicaIVA);
        }
    }
}
