using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StackUndertowMVC.Models
{
    public class Upvote
    {
        public int Id { get; set; }

        public string VoterId { get; set; }

        [ForeignKey("VoterId")]
        public virtual Users Voter { get; set; }

        public int AnswerId { get; set; }

        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }
        
    }
}