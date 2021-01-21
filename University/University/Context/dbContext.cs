using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.SQL;

namespace University.Context
{
    class dbContext
    {
        public static UniversityEntitiesSQL db = new UniversityEntitiesSQL();
    }
}
