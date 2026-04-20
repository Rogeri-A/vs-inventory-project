using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.Kpi;

namespace  InventoryProject.Module.BusinessObjects {
	public class InventoryProjectDbContext : DbContext {
		public InventoryProjectDbContext(String connectionString)
			: base(connectionString) {
		}
		public InventoryProjectDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public InventoryProjectDbContext()
			: base("name=ConnectionString") {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<TypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Resource> Resources { get; set; }
		public DbSet<FileData> FileData { get; set; }
		public DbSet<Analysis> Analysis { get; set; }
		public DbSet<HCategory> HCategories { get; set; }
        public DbSet<KpiDefinition> KpiDefinition { get; set; }
        public DbSet<KpiInstance> KpiInstance { get; set; }
        public DbSet<KpiHistoryItem> KpiHistoryItem { get; set; }
        public DbSet<KpiScorecard> KpiScorecard { get; set; }
		public DbSet<ReportDataV2> ReportDataV2 { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
	}
}