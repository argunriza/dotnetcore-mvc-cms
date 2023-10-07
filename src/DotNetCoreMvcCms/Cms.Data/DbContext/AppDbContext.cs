using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.DbContext
{
	public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public AppDbContext() { }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<PatientEntity> Patients { get; set; }

		public DbSet<AdminEntity> Admins { get; set; }

		public DbSet<DoctorEntity> Doctors { get; set; }

		public DbSet<CommentEntity> Comments { get; set; }

		public DbSet<DoctorCommentEntity> DoctorComments { get; set; }

		public DbSet<BlogCategoryEntity> BlogCategories { get; set; }

		public DbSet<ServiceBlogEntity> ServiceBlogs { get; set; }

		public DbSet<AppointmentEntity> Appointments { get; set; }

		public DbSet<ContactEntity> Contacts { get; set; }

		public DbSet<DoctorCategoryEntity> DoctorCategories { get; set; }

		public DbSet<PopularPostEntity> PopulerPosts { get; set; }

		public DbSet<NavbarEntity> Navbars { get; set; }

		public DbSet<DepartmentEntity> Departments { get; set; }

		public DbSet<UserEntity> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DoctorEntity>().HasData
				// ReSharper disable once BadParensLineBreaks
				(new DoctorEntity { Id = 1, Name = "Ali Rıza ", Surname = "Canbulan", Email = "aliriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 1, ResimDosyaAdi = "team/1.jpg" },
				 new DoctorEntity { Id = 2, Name = "xxx ", Surname = "Canbulan", Email = "alirıza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 2, ResimDosyaAdi = "team/2.jpg" },
				 new DoctorEntity { Id = 3, Name = "yyyy ", Surname = "Canbulan", Email = "alirıza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 3, ResimDosyaAdi = "team/3.jpg" },
				 new DoctorEntity { Id = 4, Name = "bbb ", Surname = "Canbulan", Email = "alirıza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 4, ResimDosyaAdi = "team/4.jpg" },
				 new DoctorEntity { Id = 5, Name = "nnnn", Surname = "Canbulan", Email = "alirıza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 5, ResimDosyaAdi = "team/1.jpg" },
				 new DoctorEntity { Id = 6, Name = "yyyy", Surname = "Canbulan", Email = "alirıza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 6, ResimDosyaAdi = "team/2.jpg" },
				 new DoctorEntity { Id = 7, Name = "Ali  ", Surname = "Canbulan", Email = "alirıza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 4, ResimDosyaAdi = "team/3.jpg" });



		}
	}
}
