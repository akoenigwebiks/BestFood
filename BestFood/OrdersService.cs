﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFood
{
    internal class OrdersService
    {
        public OrdersService() { }

        private List<OrderDTO> ToDTOList(DataTable dt)
        {
            return dt.AsEnumerable()
                    .Select(row => new OrderDTO(
                            row.Field<int>("OrderID"),
                            row.Field<DateTime>("OrderDate"),
                            row.Field<decimal>("TotalAmount"),
                            row.Field<string>("Status")
                        )
                    ).ToList();
        }

        public List<OrderDTO> GetOrdersByDate(DateTime date)
        {
            string query = $"SELECT * FROM orders WHERE OrderDate = '{date.ToString("yyyy-MM-dd")}';";
            return this.ToDTOList(AppSqlHandler.QueryIntoDataTable(query));
        }

        public List<OrderDTO> GetOrdersByStatus(string status)
        {
            string query = $"SELECT * FROM orders WHERE Status = '{status}';";
            return this.ToDTOList(AppSqlHandler.QueryIntoDataTable(query));
        }

        // get totalamount of orders
        public decimal GetTotalAmount()
        {
            // Get total amount of orders from the database
            return AppSqlHandler.QueryIntoDataTable("SELECT SUM(TotalAmount) FROM orders;")
                .AsEnumerable()
                .Select(row => row.Field<decimal>(0))
                .FirstOrDefault();
        }

        // get total number of orders
        public int GetTotalOrders()
        {
            // Get total number of orders from the database
            return AppSqlHandler.QueryIntoDataTable("SELECT COUNT(OrderID) FROM orders;")
                .AsEnumerable()
                .Select(row => row.Field<int>(0))
                .FirstOrDefault();
        }
    }
}
