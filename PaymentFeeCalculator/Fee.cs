using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFeeCalculator
{
    public static class Fee
    {
        public static decimal ReverseFeeCalculator(decimal value, decimal porcentajeComision, decimal tarifaFija, decimal iva)
        {
            return (value + tarifaFija * (1 + iva)) / (1 - porcentajeComision * (1 + iva) / 100);
        }

        public static decimal FeeCalculator(decimal value, decimal porcentajeComision, decimal tarifaFija, decimal iva)
        {
            return value * ((porcentajeComision / 100) * (1 + iva)) + tarifaFija * (1 + iva);
        }

        public static (decimal PaypalPorciento, decimal PaypalFija, decimal Paypal3, decimal Paypal6,
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

        public static (decimal PaypalPorciento, decimal PaypalFija, decimal Paypal3, decimal Paypal6,
            decimal Paypal9, decimal Paypal12, bool PaypalIVA) GetSenorPagoFees()
        {

            return (
                Properties.Settings.Default.SenorPorciento,
                Properties.Settings.Default.SenorFija,
                Properties.Settings.Default.Senor3MSI,
                Properties.Settings.Default.Senor6MSI,
                Properties.Settings.Default.Senor9MSI,
                Properties.Settings.Default.Senor12MSI,
                Properties.Settings.Default.SenorAplicaIVA);
        }

        public static (decimal PaypalPorciento, decimal PaypalFija, decimal Paypal3, decimal Paypal6,
            decimal Paypal9, decimal Paypal12, bool PaypalIVA) GetMercadoLibreFees()
        {

            return (
                Properties.Settings.Default.MercadolibrePorciento,
                Properties.Settings.Default.MercadolibreFija,
                Properties.Settings.Default.Mercadolibre3MSI,
                Properties.Settings.Default.Mercadolibre6MSI,
                Properties.Settings.Default.Mercadolibre9MSI,
                Properties.Settings.Default.Mercadolibre12MSI,
                Properties.Settings.Default.MercadolibreAplicaIVA);
        }

        public static (decimal PaypalPorciento, decimal PaypalFija, decimal Paypal3, decimal Paypal6,
            decimal Paypal9, decimal Paypal12, bool PaypalIVA) GetMercadoPagoFees()
        {

            return (
                Properties.Settings.Default.MercadopagoPorciento,
                Properties.Settings.Default.MercadopagoFija,
                Properties.Settings.Default.Mercadopago3MSI,
                Properties.Settings.Default.Mercadopago6MSI,
                Properties.Settings.Default.Mercadopago9MSI,
                Properties.Settings.Default.Mercadopago12MSI,
                Properties.Settings.Default.MercadopagoAplicaIVA);
        }

        public static (decimal PaypalPorciento, decimal PaypalFija, decimal Paypal3, decimal Paypal6,
            decimal Paypal9, decimal Paypal12, bool PaypalIVA) GetClipFees()
        {

            return (
                Properties.Settings.Default.ClipPorciento,
                Properties.Settings.Default.ClipFija,
                Properties.Settings.Default.Clip3MSI,
                Properties.Settings.Default.Clip6MSI,
                Properties.Settings.Default.Clip9MSI,
                Properties.Settings.Default.Clip12MSI,
                Properties.Settings.Default.ClipAplicaIVA);
        }
    }
}
