﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Template
{
    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    class Categories : DataAccessObject
    {

        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }
}
