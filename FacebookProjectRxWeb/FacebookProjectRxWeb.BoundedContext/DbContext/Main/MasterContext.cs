using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FacebookProjectRxWeb.BoundedContext.SqlContext;
using FacebookProjectRxWeb.Models.Main;
using FacebookProjectRxWeb.Models;
using FacebookProjectRxWeb.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace FacebookProjectRxWeb.BoundedContext.Main
{
    public class MasterContext : BaseBoundedContext, IMasterContext
    {
        public MasterContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<FacebookUser> FacebookUser { get; set; }
		            public DbSet<UserDetail> UserDetail { get; set; }
		            public DbSet<ChatMessage> ChatMessage { get; set; }
		            public DbSet<ChatMedia> ChatMedia { get; set; }
		            public DbSet<Post> Post { get; set; }
            #endregion DbSets


    }

    public interface IMasterContext : IDbContext
    {
    }
}

