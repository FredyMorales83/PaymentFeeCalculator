using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessFee
{
    public class Fee
    {
        [PrimaryKey, AutoIncrement]
        public  int ID { get; set; }
        public  string ProviderName { get; set; }
        public  string ProviderFixedPercentage { get; set; }
        public  string ProviderFixedFee { get; set; }
        public  string Provider3MsiFee { get; set; }
        public  string Provider6MsiFee { get; set; }
        public  string Provider9MsiFee { get; set; }
        public  string Provider12MsiFee { get; set; }
        public  string ProviderIva { get; set; }
    }
}
