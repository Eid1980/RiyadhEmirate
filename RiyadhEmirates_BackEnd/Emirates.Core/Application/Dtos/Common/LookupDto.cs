using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Dtos
{
    public class LookupDto<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }
}
