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
        [Column(Name = "id", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "seats")]
        public int Seats { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=liteTestDb.db");
            DataContext context = new DataContext(connection);
            Table<Company> companies = context.GetTable<Company>();

            Company nowy = new Company() { Id = 5, Seats = 234 };

            companies.InsertOnSubmit(nowy);

            try
            {
                context.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var item in companies)
            {
                Console.WriteLine("{0}\t\t{1}", item.Id, item.Seats);
            }
        }
    }
}
