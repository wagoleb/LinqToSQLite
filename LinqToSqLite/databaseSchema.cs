using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqLite
{
    public class PersonDataBase : DataContext
    {
        private string _connection;
        public PersonDataBase(string connection) : base(connection)
        {
            this._connection = connection;
        }
        public Table<Person> personTable;

        public void Initialize()
        {
            PersonDataBase newDataBase = new PersonDataBase(this._connection);
            if (!newDataBase.DatabaseExists())
                newDataBase.CreateDatabase();
        }
    }

    // tables info
    [Table(Name = "PersonTable")]
    public class Person
    {
        [Column(CanBeNull = false, IsPrimaryKey = true, Name = "Id")]
        public UInt32 Id;
        [Column(Name = "firstName", CanBeNull = false)]
        public string firstName;
        [Column(Name = "secondName", CanBeNull = false)]
        public string secondName;
        [Column(Name = "age", CanBeNull = false)]
        public uint age;
    }
}



