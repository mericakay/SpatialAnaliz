using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SpatialGeoAnalizProject
{
     class publicConnectionString
    {
        string connectionString = "Server=192.168.1.47;Port=5432;User Id=postgres;Password=postgres;Database=dd";
        public string connstring
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
       
     
    }
}
