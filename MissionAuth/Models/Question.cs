using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionAuth.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [ForeignKey("Mission")]
        public int MissionId { get; set; }
        public virtual Mission Mission { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required, DisplayName("Question Description"), StringLength(500, MinimumLength = 3, ErrorMessage = "Question must be between 3 and 500 characters long."),
            RegularExpression(@"^[A-Z].*$", ErrorMessage = "Capitalize question.")]
        public String QuestionDescription { get; set; }
    }
}