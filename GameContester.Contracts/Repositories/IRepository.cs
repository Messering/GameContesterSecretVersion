﻿using System.Collections.Generic;

namespace GameContester.Contracts.Repositories
{
    public interface IRepository<T, TKey>
    {
        void Add(T entity);
        void Delete(TKey entity);
        T Find(TKey id);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
