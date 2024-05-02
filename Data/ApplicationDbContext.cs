using impromed_client.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impromed_client.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ConStr")
        {

        }
    }
}
