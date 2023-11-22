using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AskForAnswer.Models
{
    public class Question
    {
        public int  Id { get; set; }
        public String? Title { get; set; }
        public String? Description { get; set; }

        // Relations
        public String? IdentityUserId { get; set; }

        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        public List<Answer>? Answers { get; set; }

    }
}
