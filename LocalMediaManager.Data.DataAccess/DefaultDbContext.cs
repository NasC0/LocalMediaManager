using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalMediaManager.Data.DataAccess.Contracts;
using LocalMediaManager.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LocalMediaManager.Data.DataAccess
{
    public class DefaultDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public DefaultDbContext()
            : base("LocalMediaManager", throwIfV1Schema: false)
        {
            
        }

        public static DefaultDbContext Create()
        {
            return new DefaultDbContext();
        }
    }
}
