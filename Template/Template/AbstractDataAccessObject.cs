﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Template
{
    /// <summary>

    /// The 'AbstractClass' abstract class

    /// </summary>

    abstract class DataAccessObject

    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app

            connectionString =
              "provider=Microsoft.JET.OLEDB.4.0; " +
              "data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
