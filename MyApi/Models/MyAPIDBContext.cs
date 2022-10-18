using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using MyApi.Models;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using static System.Net.WebRequestMethods;

namespace MyApi.Models
{
	public class MyApiDBContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public MyApiDBContext(DbContextOptions<MyApiDBContext> options, IConfiguration configuration)
			: base(options)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var connectionString = Configuration.GetConnectionString("CustomerDataService");
			options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
		}

		public DbSet<Customer> Customers { get; set; } = null;
		public DbSet<Email> Emails { get; set; } = null;
	}
}