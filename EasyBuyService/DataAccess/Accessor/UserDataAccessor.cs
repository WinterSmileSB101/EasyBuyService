using EasyBuyService.DataAccess.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EasyBuyService.DataAccess.Accessor
{
    public class UserDataAccessor : IDataAccessor
    {
        public int Create<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public int Delete<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Query<TEntity>(string condition) where TEntity : class, new()
        {
            using (var conn = SqlHelper.Instance.GetConnection())
            {
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@Where", condition));
                string SECECT = "SELECT * FROM dbo.User Where @Where";

                return SqlHelper.Instance.ExecuteScalar<List<TEntity>>(SECECT, paras);
            }
        }

        public int Update<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}