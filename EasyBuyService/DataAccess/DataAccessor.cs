using EasyBuyService.DataAccess.Helper;
using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EasyBuyService.DataAccess
{
    public class DataAccessor: IDataAccessor
    {

        #region fields
        private static string SELECT = "SELECT * FROM";
        #endregion

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
            using (var conn = SqlHelper.Instance.GetConnection())
            {
                List<TEntity> entityList = new List<TEntity>();
                //获取泛型的类型
                Type type = typeof(TEntity);
                //获取表的名称
                object[] tableNames = type.GetCustomAttributes(typeof(TableAttribute), false);
                if (tableNames != null)
                {
                    //通过这种方式替换，可以防止 sql 注入
                    SELECT = String.Format(SELECT + " {0} {1}", ((TableAttribute)tableNames[0]).TableName, condition);
                }

                //通过类型获取所有属性
                var infos = type.GetProperties();

                var reader = SqlHelper.Instance.ExecuteQuery(conn, SELECT, new List<SqlParameter> { });

                //通过反射有类型创建出对应 object 的实例
                object entity = Activator.CreateInstance(type);

                while (reader.Read())
                {
                    foreach (var info in infos)
                    {
                        //获取属性对应的特性信息（匹配）
                        object[] attributes = info.GetCustomAttributes(typeof(FieldAttribute), false);

                        if (attributes != null)
                        {
                            //通过反射设置对应的属性值，
                            if (!(reader[((FieldAttribute)attributes[0]).Fields] == DBNull.Value))
                            {
                                //不为空，赋值，这里entity代表是需要设置属性的实例，info 是指需要设置的属性
                                info.SetValue(entity, reader[((FieldAttribute)attributes[0]).Fields], null);
                            }
                        }
                    }
                    entityList.Add((TEntity)entity);
                }
            }
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