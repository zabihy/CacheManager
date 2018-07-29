using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Sample.Contracts.Queries
{
    public interface IExpressionQuery<T>:IQuery
    {
        Expression<Func<T, bool>> Exp{ get; }
    }
}
