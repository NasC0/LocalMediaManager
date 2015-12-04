using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMediaManager.Configuration.Contracts
{
    public interface IConfigurationBuilder
    {
        Configuration BuildConfiguration(string configLocation);
    }
}
