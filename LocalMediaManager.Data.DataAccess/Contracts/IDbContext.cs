using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalMediaManager.Data.Models;

namespace LocalMediaManager.Data.DataAccess.Contracts
{
    public interface IDbContext
    {
        IDbSet<ApplicationUser> Users { get; set; }
    }
}
