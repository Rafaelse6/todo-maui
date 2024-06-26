﻿using SQLite;

namespace ToDoApp.Services
{
    public class DatabaseServico<T> where T : new()
    {
        private SQLiteAsyncConnection _database;

        public DatabaseServico(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<T>().Wait();
        }

        public Task<int> IncluirAsync(T item)
        {
            return _database.InsertAsync(item);
        }

        public Task<List<T>> TodosAsync()
        {
            return _database.Table<T>().ToListAsync();
        }

        public Task<int> QuantidadeAsync()
        {
            return _database.Table<T>().CountAsync();
        }
    }
}
