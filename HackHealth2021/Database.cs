using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HackHealth2021
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Patient>().Wait();
        }

        public Task<List<Patient>> GetPeopleAsync()
        {
            return _database.Table<Patient>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Patient patient)
        {
            return _database.InsertAsync(patient);
        }
    }
}
