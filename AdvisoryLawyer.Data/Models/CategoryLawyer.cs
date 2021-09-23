﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AdvisoryLawyer.Data.Models
{
    public partial class CategoryLawyer
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int LawyerId { get; set; }

        public virtual Category Category { get; set; }
        public virtual UserAccount Lawyer { get; set; }
    }
}
