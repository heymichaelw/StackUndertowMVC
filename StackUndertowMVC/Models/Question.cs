using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StackUndertowMVC.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public string OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual Users Owner { get; set; }
    }
}