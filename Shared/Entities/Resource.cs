using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDK.Shared.Entities
{
    public class Resource : BaseEntity<int>
    {
        [Key]
		[Required]
		public override int Rowid { get; set; }

        [Required]
		[StringLength(500)]
		public string Id { get; set; }

        [Required]
		[StringLength(2000)]
		public virtual string Description { get; set; }
    }
}