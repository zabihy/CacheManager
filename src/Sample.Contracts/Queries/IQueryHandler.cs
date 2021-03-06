﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Contracts.Queries
{
    public interface IQueryHandler<TQuery, TResult> where TQuery:IQuery
    {
        TResult Execute(TQuery query);
    }
}
