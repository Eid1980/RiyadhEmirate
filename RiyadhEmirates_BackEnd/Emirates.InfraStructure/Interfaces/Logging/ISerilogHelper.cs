using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.InfraStructure.Interfaces.Logging
{
    public interface ISerilogHelper : ILoggerHelper<ILogger>
    {
        void TestStaticLogger();
        ILogger InitializeLogger(IConfigurationRoot configuration, string configurationSection);
    }
}
