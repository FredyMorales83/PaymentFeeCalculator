using FeeDataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFeeCalculator
{
    public enum Providers
    {
        Paypal,
        SenorPago,
        MercadoLibre,
        MercadoPago,
        Clip
    }

    public static class FeeServices
    {
        static FeeDatabase database;

        // Create the database connection as a singleton.
        public static FeeDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FeeDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Fees.db3"));
                }
                return database;
            }
        }

        public static decimal ReverseFeeCalculator(decimal value, decimal porcentajeComision, decimal tarifaFija, decimal iva)
        {
            return (value + tarifaFija * (1 + iva)) / (1 - porcentajeComision * (1 + iva) / 100);
        }

        public static decimal FeeCalculator(decimal value, decimal porcentajeComision, decimal tarifaFija, decimal iva)
        {
            return value * ((porcentajeComision / 100) * (1 + iva)) + tarifaFija * (1 + iva);
        }

        public static async Task<(decimal ProviderPorciento, decimal ProviderFija, decimal Provider3Msi, decimal Provider6Msi,
            decimal Provider9Msi, decimal Provider12Msi, bool ProviderIVA, decimal tasaIva)> GetFees(Providers provider)
        {

            var fees = await GetFeesByProviderNameAsync(provider.ToString());

            
            switch (fees)
            {
                case null:
                    return (0, 0, 0, 0, 0, 0, false, 0);
                default:
                    return (Convert.ToDecimal(fees.ProviderFixedPercentage),
                            Convert.ToDecimal(fees.ProviderFixedFee),
                            Convert.ToDecimal(fees.Provider3MsiFee),
                            Convert.ToDecimal(fees.Provider6MsiFee),
                            Convert.ToDecimal(fees.Provider9MsiFee),
                            Convert.ToDecimal(fees.Provider12MsiFee), 
                            Convert.ToBoolean(fees.ApplyTax),
                            Convert.ToDecimal(fees.ProviderIva));
            }

        }

        public static async Task<Fee> GetFeesByProviderNameAsync(string provider)
        {
            return await Database.GetFeesByProviderNameAsync(provider);
        }

        public static async Task<List<Fee>> GetAllFeesAsync()
        {
            return await Database.GetFeesAsync();
        }

        public static async Task SaveFees(List<Fee> fees)
        {
            foreach (var fee in fees)
            {
                await SaveFee(fee);
            }
        }

        public static async Task SaveFee(Fee fee)
        {
            await Database.SaveFeeAsync(fee);
        }
    }
}
