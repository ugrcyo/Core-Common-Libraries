﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
       //[Required(ErrorMessage ="Name alanı boş bırakılamaz! --Attribute")]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime? Birthday { get; set; }
        public IList<Address> Addresses { get; set; }
        public Gender Gender { get; set; }
    }
}
