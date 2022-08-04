using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Domain
{
    public static class EmiratesDbSchemas
    {
        public static string DataManagement { get; } = "DataManagement";
        public static string FileManager { get; } = "FileManager";
        public static string LookupSehema { get; } = "Lookup";
        public static string RequestSehema { get; } = "Request";
        public static string SecuritySehema { get; } = "Security";
    }
}
