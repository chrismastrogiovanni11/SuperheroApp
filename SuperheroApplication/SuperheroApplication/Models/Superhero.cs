﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroApplication.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }

        public string SuperheroName { get; set; }

        public string AlterEgoName { get; set; }

        public string PrimaryAbility { get; set; }

        public string SecondaryAbility { get; set; }

        public string CatchPhrase { get; set; }

    }
}