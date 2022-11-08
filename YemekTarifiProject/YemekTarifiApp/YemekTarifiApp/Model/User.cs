﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekTarifiApp.Model
{
    internal class User :BaseEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Comment> Comments { get; set; } 
    }
}