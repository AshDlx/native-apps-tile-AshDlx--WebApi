using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PartyAtHomes_Lib
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
