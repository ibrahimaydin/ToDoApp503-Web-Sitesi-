using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoApp503.Models
{
    [Authorize]
    public class Department:BaseEntity
    {
        [StringLength(200, ErrorMessage = "200 karakterden fazla girdiniz")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Ad")]
        public string Name { get; set; }
        public virtual ICollection<ToDoItem> ToDoItems { get; set; }
    }
}