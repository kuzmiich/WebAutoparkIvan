﻿using WebAutopark.Core.Entities.Base;

namespace WebAutopark.DataAccess.Repositories.Specification.Provider
{
    public interface IDbProvider
    {
        EntityInfo GetDbEntity<T>(T entity);
    }
}