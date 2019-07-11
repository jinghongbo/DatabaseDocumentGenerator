using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDocumentGenerator.Models
{
    public class DbTable
    {
        public IList<DbTableColumn> Columns { get; set; }
    }
}
