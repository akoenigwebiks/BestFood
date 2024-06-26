﻿using BestFood.Models;
using System.Data;

namespace BestFood.DAL
{
    internal class CategoryService
    {
        private readonly string categoryTable = "dbo.categories";
        public CategoryService() { }

        public List<CategoryDTO> GetCategories()
        {
            string query = $"SELECT * FROM {categoryTable};";
            return AppSqlHandler.QueryIntoDataTable(query)
                .AsEnumerable()
                .Select(row => new CategoryDTO(
                    row.Field<string>("Name"),
                    row.Field<int>("CategoryID")
                    )
                )
                .ToList();
        }

        public string GetCategory(int id)
        {
            string query = $"SELECT Name FROM {categoryTable} WHERE CategoryID = {id};";
            return AppSqlHandler.QueryIntoDataTable(query).Rows[0].Field<string>("Name");
        }

        public bool AddOne(string categoryToAdd)
        {
            string query = $"INSERT INTO {categoryTable} (Name) VALUES ('{categoryToAdd.Replace("'", "''")}');";
            return AppSqlHandler.ExecuteNonQuery(query);
        }
    }
}
