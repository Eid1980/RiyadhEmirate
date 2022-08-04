using System;
using System.Collections.Generic;
using System.Text;

namespace Emirates.Core.Application.Interfaces.Response
{
    public interface IResponse<TEntity> where TEntity: class
    {
        public string Message { get; set; }
        public TEntity Entity { get; set; }
    }
}
