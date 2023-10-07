﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Models.Entities
{
	public class UserEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[StringLength(50)]
		public string Surname { get; set; } = string.Empty;

		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;

		[Required]
		[MinLength(8)]
		public string Password { get; set; } = string.Empty;

		public bool IsDisabled { get; set; } = false;

		public int CreatedBy { get; set; }

		public DateTime CreatedDate { get; set; }

		public int LastModifiedBy { get; set; }

		public DateTime? LastModifiedDate { get; set; }
	}
}
