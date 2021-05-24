using System;
using System.Collections.Generic;

namespace Planner.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
         void Create(T entry);
        IEnumerable<T> Read(Func<T, bool> filter);
        T Update();
        bool Delete();
    }
}