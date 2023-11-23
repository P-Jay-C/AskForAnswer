using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace AskForAnswer.Models
{
	public class Answer
	{
		public int Id { get; set; }
		public string Content { get; set; }

		//Relations
		[Required]
		public string? IdentityUserId { get; set; }
		[ForeignKey("IdentityUserId")]
		[Required]
		public IdentityUser? User { get; set; }

		public int? QuestionId { get; set; }
		[ForeignKey("QuestionId")]
		public Question? Question { get; set; }
	}
}
