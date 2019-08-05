﻿using BudgApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgApp.Models
{
    public class TransactionItemList
    {
        public int TransactionID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        [Display(Name = "Amount")]
        public float TransactionAmount { get; set; }
        [Display(Name = "Date")]
        public DateTime TransactionDate { get; set; }
    }
}
