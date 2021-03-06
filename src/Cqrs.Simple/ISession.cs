﻿using System;
using System.Data;

namespace Cqrs.Simple
{
    public interface ISession
    {
        T Run<T>(Func<IDbConnection, T> func);
    }
}