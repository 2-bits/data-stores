﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Halforbit.DataStores.Interface
{
    public interface IQuerySession<TKey, TValue> : IDisposable
    {
        IQueryable<TValue> Query(Expression<Func<TKey, bool>> predicate = null);
    }
}
