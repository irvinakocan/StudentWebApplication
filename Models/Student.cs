﻿using System.ComponentModel.DataAnnotations;

namespace StudentWebApplication.Models
{
    public class Student
    {
        [Key]
        public int BrojIndeksa { get; set; }
        public VrstaStudenta Vrsta { get; set; }
        public int GodinaStudija { get; set; }

        public Student() { }
    }
}
