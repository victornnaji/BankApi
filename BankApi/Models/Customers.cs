﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
