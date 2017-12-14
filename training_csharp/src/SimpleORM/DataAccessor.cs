using System;
using System.Collections.Generic;

namespace Newegg.Internship.CSharpTraining.SimpleORM
{
    public class DataAccessor : IDataAccessor
    {
        public DataAccessor()
        {
            // TODO: Implement this constructor
        }

        public DataAccessor(string connectionString)
        {
            // TODO: Implement this constructor
        }

        public List<TEntity> Query<TEntity>(string condition) where TEntity : class, new()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int Create<TEntity>(TEntity entity) where TEntity : class
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int Update<TEntity>(TEntity entity) where TEntity : class
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public int Delete<TEntity>(TEntity entity) where TEntity : class
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
