﻿using AskForAnswer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AskForAnswer.Data
{

		public class ApplicationDbContext : IdentityDbContext
		{
			public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
			{
			}
			public DbSet<Question> Questions { get; set; }
			public DbSet<Answer> Answers { get; set; }
		}
	}

