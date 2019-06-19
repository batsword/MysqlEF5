using MysqlEF.models;
using System.Data.Entity;

namespace EFCodeFirst
{
    public class DContext : DbContext
    {
        /// <summary>
        /// 添加构造函数,name为config文件中数据库连接字符串的name
        /// </summary>
        public DContext() : base("name=MyContext")
        {

        }

        #region 数据集
        public DbSet<UserEntity> Users { get; set; }

        #endregion  
    }
}