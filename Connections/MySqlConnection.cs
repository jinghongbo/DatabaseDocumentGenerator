using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseDocumentGenerator.Attributes;
using DatabaseDocumentGenerator.Models;

namespace DatabaseDocumentGenerator.Connections
{
    [Display("MySql")]
    public class MySqlConnection : IConnection
    {
        public string ConnectionType => "MySql";

        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IDbConnection Connection => throw new NotImplementedException();

        public IEnumerable<DbTable> GetTables()
        {
            throw new NotImplementedException();
        }
    }
}
