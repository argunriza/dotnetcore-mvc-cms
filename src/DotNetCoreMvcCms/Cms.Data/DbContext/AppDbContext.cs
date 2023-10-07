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
			modelBuilder.Entity<DoctorEntity>().HasData(new DoctorEntity { Id = 1, Name = "Rıza ", Surname = "Adaadad", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 1, ResimDosyaAdi = "team/1.jpg" },
			                                            new DoctorEntity { Id = 2, Name = "Meryem ", Surname = "Bdada", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 2, ResimDosyaAdi = "team/2.jpg" },
			                                            new DoctorEntity { Id = 3, Name = "Emre ", Surname = "Cadad", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 3, ResimDosyaAdi = "team/3.jpg" },
			                                            new DoctorEntity { Id = 4, Name = "Mert ", Surname = "Dadada", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 4, ResimDosyaAdi = "team/4.jpg" },
			                                            new DoctorEntity { Id = 5, Name = "Seto", Surname = "Eadad", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 5, ResimDosyaAdi = "team/1.jpg" },
			                                            new DoctorEntity { Id = 6, Name = "Öykü", Surname = "Fansdan", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 6, ResimDosyaAdi = "team/2.jpg" },
			                                            new DoctorEntity { Id = 7, Name = "Hazal  ", Surname = "Gdsdsn", Email = "argunriza@canbulan.com", Phone = "05554443322", Password = "1234", CategoryId = 4, ResimDosyaAdi = "team/3.jpg" });

			modelBuilder.Entity<DepartmentEntity>().HasData(new DepartmentEntity { Id = 1, Name = "Opthomology ", Description = "Saepe nulla praesentium eaque omnis perferendis a doloremque." },
			                                                new DepartmentEntity { Id = 2, Name = "Cardiology", Description = "Saepe nulla praesentium eaque omnis perferendis a doloremque." },
			                                                new DepartmentEntity { Id = 3, Name = "Dental Care", Description = "Saepe nulla praesentium eaque omnis perferendis a doloremque." },
			                                                new DepartmentEntity { Id = 4, Name = "Child Care", Description = "Saepe nulla praesentium eaque omnis perferendis a doloremque." },
			                                                new DepartmentEntity { Id = 5, Name = "Pulmology", Description = "Saepe nulla praesentium eaque omnis perferendis a doloremque." },
			                                                new DepartmentEntity { Id = 6, Name = "Gynecology", Description = "Saepe nulla praesentium eaque omnis perferendis a doloremque." });

			modelBuilder.Entity<PatientEntity>().HasData(new PatientEntity
			{
				Id       = 1,
				Name     = "Ali Rızaxx ",
				Surname  = "Canbulanxx",
				Email    = "alirıza@canbulanxx.com",
				Phone    = "05554443311",
				Password = "12345"



			}, new PatientEntity
			{
				Id       = 2,
				Name     = "mehmet ",
				Surname  = "Canbulanxx",
				Email    = "alirıza@canbulanxx.com",
				Phone    = "05554443311",
				Password = "12345"
			});

			modelBuilder.Entity<AdminEntity>().HasData(new AdminEntity
			{
				Id       = 1,
				Name     = "Ali Rızaxxyy ",
				Surname  = "Canbulanxxyy",
				Email    = "alirıza@canbulanxxyy.com",
				Phone    = "05554442211",
				Password = "1234564343"

			});

			modelBuilder.Entity<NavbarEntity>().HasData(new NavbarEntity { Id = 1, Name = "Home" },
			                                            new NavbarEntity { Id = 2, Name = "About" },
			                                            new NavbarEntity { Id = 3, Name = "Services" },
			                                            new NavbarEntity { Id = 4, Name = "Departments" },
			                                            new NavbarEntity { Id = 5, Name = "Doctors" },
			                                            new NavbarEntity { Id = 6, Name = "Blog" },
			                                            new NavbarEntity { Id = 7, Name = "Contact" });

			modelBuilder.Entity<DoctorCategoryEntity>().HasData(new DoctorCategoryEntity { Id = 1, Name = "Cardiology" },
			                                                    new DoctorCategoryEntity { Id = 2, Name = "Dental" },
			                                                    new DoctorCategoryEntity { Id = 3, Name = "Neurology" },
			                                                    new DoctorCategoryEntity { Id = 4, Name = "Medicine" },
			                                                    new DoctorCategoryEntity { Id = 5, Name = "Pediatric" },
			                                                    new DoctorCategoryEntity { Id = 6, Name = "Traumatology" });

			base.OnModelCreating(modelBuilder);
		}
	}
}
