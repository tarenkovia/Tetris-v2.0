﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ORMDal
{
    public partial class Users
    {
        public Users()
        {
            Games = new HashSet<Games>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Password { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<Games> Games { get; set; }
    }
}
