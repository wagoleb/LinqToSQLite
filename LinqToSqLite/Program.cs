using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Data.Linq;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqLite
{
    [Table(Name = "company")]
    class Company
    {
        [Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "seats")]
        public int Seats { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SQLiteConnection(@"Data Source=liteTestDb.db");
            var context = new DataContext(connection);
            // context.CreateDatabase();
            // context.Connection.Close();
            var companies = context.GetTable<Company>();

            foreach (var item in companies)
            {
                Console.WriteLine(item);
                Console.WriteLine("{0}\t\t{1}", item.Id, item.Seats);
            }
        }
    }
}
