using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.data
{
    public class DBC :DbContext
    {
		public DBC(DbContextOptions<DBC> options) : base(options)
		{

		}

		public DbSet<mainm> mainm { get; set; }
		public DbSet<user> user { get; set; }
	}
}
