﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Entities
{
    [Table("claims", Schema = "App")]
    public class ClaimEntity : EntityBase<Guid>
    {
        public Guid PolicyId { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
