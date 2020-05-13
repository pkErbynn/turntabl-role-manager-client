﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurntablRoleManager.Client.Model
{
    public class RoleModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
