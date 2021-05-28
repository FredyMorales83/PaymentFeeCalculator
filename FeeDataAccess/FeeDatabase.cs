using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FeeDataAccess
{
    public class FeeDatabase
    {
        static SQLiteAsyncConnection connection;
        static FeeDatabase database;

        //static readonly string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Fees.db3");

        //public static FeeDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new FeeDatabase(path);
        //        }
        //        return database;
        //    }
        //}

        public FeeDatabase(string dbPath = "")
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<Fee>().Wait();
        }

        public Task<List<Fee>> GetFeesAsync()
        {
            //Get all Fees.
            return connection.Table<Fee>().ToListAsync();
        }

        public Task<Fee> GetFeeByIdAsync(int id)
        {
            // Get a specific Fee.
            return connection.Table<Fee>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<Fee> GetFeesByProviderNameAsync(string providerName)
        {
            // Get a specific Fee.
            return connection.Table<Fee>()
                            .Where(f => f.ProviderName.Equals(providerName))
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveFeeAsync(Fee fee)
        {
            if (fee.ID != 0)
            {
                // Update an existing fee.
                return connection.UpdateAsync(fee);
            }
            else
            {
                // Save a new fee.
                return connection.InsertAsync(fee);
            }
        }

        public Task<int> DeleteFeeAsync(Fee fee)
        {
            // Delete a fee.
            return connection.DeleteAsync(fee);
        }
    }
}
