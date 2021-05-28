using FeeDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private async void SaveFeeConfiguration()
        {
            var tasaIVA = nudTasaIVA.Value.ToString();

            var paypal = await FeeServices.GetFeesByProviderNameAsync(Providers.Paypal.ToString());

            paypal.ProviderFixedPercentage = nudPaypalPorciento.Value.ToString();
            paypal.ProviderFixedFee = nudPaypalFija.Value.ToString();
            paypal.Provider3MsiFee = nudPaypal3MSI.Value.ToString();
            paypal.Provider6MsiFee = nudPaypal6MSI.Value.ToString();
            paypal.Provider9MsiFee = nudPaypal9MSI.Value.ToString();
            paypal.Provider12MsiFee = nudPaypal12MSI.Value.ToString().ToString();
            paypal.ApplyTax = Convert.ToInt32(cbPaypalIVA.Checked);
            paypal.ProviderIva = tasaIVA;

            var senor = await FeeServices.GetFeesByProviderNameAsync(Providers.SenorPago.ToString());

            senor.ProviderFixedPercentage = nudSenorPorciento.Value.ToString();
            senor.ProviderFixedFee = nudSenorFija.Value.ToString();
            senor.Provider3MsiFee = nudSenor3MSI.Value.ToString();
            senor.Provider6MsiFee = nudSenor6MSI.Value.ToString();
            senor.Provider9MsiFee = nudSenor9MSI.Value.ToString();
            senor.Provider12MsiFee = nudSenor12MSI.Value.ToString();
            senor.ApplyTax = Convert.ToInt32(cbSenorIVA.Checked);
            senor.ProviderIva = tasaIVA;

            var mercadoLibre = await FeeServices.GetFeesByProviderNameAsync(Providers.MercadoLibre.ToString());

            mercadoLibre.ProviderFixedPercentage = nudMercadolibrePorciento.Value.ToString();
            mercadoLibre.ProviderFixedFee = nudMercadolibreFija.Value.ToString();
            mercadoLibre.Provider3MsiFee = nudMercadolibre3MSI.Value.ToString();
            mercadoLibre.Provider6MsiFee = nudMercadolibre6MSI.Value.ToString();
            mercadoLibre.Provider9MsiFee = nudMercadolibre9MSI.Value.ToString();
            mercadoLibre.Provider12MsiFee = nudMercadolibre12MSI.Value.ToString();
            mercadoLibre.ApplyTax = Convert.ToInt32(cbMercadolibreIVA.Checked);
            mercadoLibre.ProviderIva = tasaIVA;

            var mercadoPago = await FeeServices.GetFeesByProviderNameAsync(Providers.MercadoPago.ToString());

            mercadoPago.ProviderFixedPercentage = nudMercadopagoPorciento.Value.ToString();
            mercadoPago.ProviderFixedFee = nudMercadopagoFija.Value.ToString();
            mercadoPago.Provider3MsiFee = nudMercadopago3MSI.Value.ToString();
            mercadoPago.Provider6MsiFee = nudMercadopago6MSI.Value.ToString();
            mercadoPago.Provider9MsiFee = nudMercadopago9MSI.Value.ToString();
            mercadoPago.Provider12MsiFee = nudMercadopago12MSI.Value.ToString();
            mercadoPago.ApplyTax = Convert.ToInt32(cbMercadopagoIVA.Checked);
            mercadoPago.ProviderIva = tasaIVA;

            var clip = await FeeServices.GetFeesByProviderNameAsync(Providers.Clip.ToString());

            clip.ProviderFixedPercentage = nudClipPorciento.Value.ToString();
            clip.ProviderFixedFee = nudClipFija.Value.ToString();
            clip.Provider3MsiFee = nudClip3MSI.Value.ToString();
            clip.Provider6MsiFee = nudClip6MSI.Value.ToString();
            clip.Provider9MsiFee = nudClip9MSI.Value.ToString();
            clip.Provider12MsiFee = nudClip12MSI.Value.ToString();
            clip.ApplyTax = Convert.ToInt32(cbClipIVA.Checked);
            clip.ProviderIva = tasaIVA;

            var listFees = new List<Fee>() { paypal, senor, mercadoLibre, mercadoPago, clip };

            await FeeServices.SaveFees(listFees);

            MessageBox.Show("Configuracion guardada satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            ReadFeeConfiguration();
        }

        private async void ReadFeeConfiguration()
        {
            var fees = await FeeServices.GetAllFeesAsync();

            nudTasaIVA.Value = Convert.ToDecimal(fees.FirstOrDefault().ProviderIva);

            var paypal = fees.Where(p => p.ProviderName.Equals(Providers.Paypal.ToString())).FirstOrDefault();

            nudPaypalPorciento.Value = Convert.ToDecimal(paypal.ProviderFixedPercentage);
            nudPaypalFija.Value = Convert.ToDecimal(paypal.ProviderFixedFee);
            nudPaypal3MSI.Value = Convert.ToDecimal(paypal.Provider3MsiFee);
            nudPaypal6MSI.Value = Convert.ToDecimal(paypal.Provider6MsiFee);
            nudPaypal9MSI.Value = Convert.ToDecimal(paypal.Provider9MsiFee);
            nudPaypal12MSI.Value = Convert.ToDecimal(paypal.Provider12MsiFee);
            cbPaypalIVA.Checked = Convert.ToBoolean(paypal.ApplyTax);

            var senor = fees.Where(p => p.ProviderName.Equals(Providers.SenorPago.ToString())).FirstOrDefault();

            nudSenorPorciento.Value = Convert.ToDecimal(senor.ProviderFixedPercentage);
            nudSenorFija.Value = Convert.ToDecimal(senor.ProviderFixedFee);
            nudSenor3MSI.Value = Convert.ToDecimal(senor.Provider3MsiFee);
            nudSenor6MSI.Value = Convert.ToDecimal(senor.Provider6MsiFee);
            nudSenor9MSI.Value = Convert.ToDecimal(senor.Provider9MsiFee);
            nudSenor12MSI.Value = Convert.ToDecimal(senor.Provider12MsiFee);
            cbSenorIVA.Checked = Convert.ToBoolean(senor.ApplyTax);

            var mercadoLibre = fees.Where(p => p.ProviderName.Equals(Providers.MercadoLibre.ToString())).FirstOrDefault();

            nudMercadolibrePorciento.Value = Convert.ToDecimal(mercadoLibre.ProviderFixedPercentage);
            nudMercadolibreFija.Value = Convert.ToDecimal(mercadoLibre.ProviderFixedFee);
            nudMercadolibre3MSI.Value = Convert.ToDecimal(mercadoLibre.Provider3MsiFee);
            nudMercadolibre6MSI.Value = Convert.ToDecimal(mercadoLibre.Provider6MsiFee);
            nudMercadolibre9MSI.Value = Convert.ToDecimal(mercadoLibre.Provider9MsiFee);
            nudMercadolibre12MSI.Value = Convert.ToDecimal(mercadoLibre.Provider12MsiFee);
            cbMercadolibreIVA.Checked = Convert.ToBoolean(mercadoLibre.ApplyTax);

            var mercadoPago = fees.Where(p => p.ProviderName.Equals(Providers.MercadoPago.ToString())).FirstOrDefault();

            nudMercadopagoPorciento.Value = Convert.ToDecimal(mercadoPago.ProviderFixedPercentage);
            nudMercadopagoFija.Value = Convert.ToDecimal(mercadoPago.ProviderFixedFee);
            nudMercadopago3MSI.Value = Convert.ToDecimal(mercadoPago.Provider3MsiFee);
            nudMercadopago6MSI.Value = Convert.ToDecimal(mercadoPago.Provider6MsiFee);
            nudMercadopago9MSI.Value = Convert.ToDecimal(mercadoPago.Provider9MsiFee);
            nudMercadopago12MSI.Value = Convert.ToDecimal(mercadoPago.Provider12MsiFee);
            cbMercadopagoIVA.Checked = Convert.ToBoolean(mercadoPago.ApplyTax);

            var clip = fees.Where(p => p.ProviderName.Equals(Providers.Clip.ToString())).FirstOrDefault();

            nudClipPorciento.Value = Convert.ToDecimal(clip.ProviderFixedPercentage);
            nudClipFija.Value = Convert.ToDecimal(clip.ProviderFixedFee);
            nudClip3MSI.Value = Convert.ToDecimal(clip.Provider3MsiFee);
            nudClip6MSI.Value = Convert.ToDecimal(clip.Provider6MsiFee);
            nudClip9MSI.Value = Convert.ToDecimal(clip.Provider9MsiFee);
            nudClip12MSI.Value = Convert.ToDecimal(clip.Provider12MsiFee);
            cbClipIVA.Checked = Convert.ToBoolean(clip.ApplyTax);
        }
    }
}
