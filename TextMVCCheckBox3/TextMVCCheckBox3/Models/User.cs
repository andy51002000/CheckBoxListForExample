using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextMVCCheckBox3.Models
{
    public class User
    {
        public int? UserID { get; set; }
        public string Account { get; set; }
        public ICollection<Role> Roles = new List<Role>();
    }
}