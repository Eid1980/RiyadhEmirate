using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.InfraStructure.Interfaces.Logging
{
    public interface ILoggerHelper<TLogger>
    {
        TLogger Logger { get; }

        void TestLogger();
        string GetContextInfoForLogging([CallerFilePath] string callerFilePath = null,
            [CallerMemberName] string callerMethodName = null,
            [CallerLineNumber] int callerLineNumber = 0);
    }
}
