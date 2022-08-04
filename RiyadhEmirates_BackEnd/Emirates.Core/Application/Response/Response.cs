using Emirates.Core.Application.Interfaces.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Response
{
    public class Response<TEntity> : IResponse<TEntity> 
        where TEntity : class
    {
        public string Message { get; set; }
        public TEntity Entity { get; set; }
    }
}
