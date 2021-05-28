using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessFee
{
    public class FeeDatabase
    {
        readonly SQLiteAsyncConnection database;

        public FeeDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Fee>().Wait();
        }

        public Task<List<Fee>> GetFeesAsync()
        {
            //Get all Fees.
            return database.Table<Fee>().ToListAsync();
        }

        public Task<Fee> GetFeeAsync(int id)
        {
            // Get a specific Fee.
            return database.Table<Fee>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<Fee> GetFeeByNameAsync(string name)
        {
            // Get a specific Fee.
            return database.Table<Fee>()
                            .Where(f => f.ProviderName.Equals(name))
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveFeeAsync(Fee fee)
        {
            if (fee.ID != 0)
            {
                // Update an existing fee.
                return database.UpdateAsync(fee);
            }
            else
            {
                // Save a new fee.
                return database.InsertAsync(fee);
            }
        }

        public Task<int> DeleteFeeAsync(Fee fee)
        {
            // Delete a fee.
            return database.DeleteAsync(fee);
        }
    }
}
