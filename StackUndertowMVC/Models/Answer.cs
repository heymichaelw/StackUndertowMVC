using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StackUndertowMVC.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int Score { get; set; }

        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }
}