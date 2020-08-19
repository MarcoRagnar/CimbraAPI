﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CimbraAPI.DTOs
{
    public class ActorCreacionDTO
    {
        [Required]
        [StringLength(120)]

        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //public string Foto { get; set; }
    }
}
