using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SIMA.DataAccess.Base
{
    public class DataAccessBase
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private string _connectionString = "Data Source=.;Initial Catalog=SIMA;Integrated Security=True";        

        public SqlConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public SqlCommand Command
        {
            get { return _command; }
            set { _command = value; }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
        }

        public DataAccessBase()
        {
            _connection = new SqlConnection(_connectionString);
        }
    }
}
