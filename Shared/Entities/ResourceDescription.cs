using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDK.Shared.Entities
{
    public class ResourceDescription : BaseEntity<int>
    {
        [Key]
		[Required]
		public override int Rowid { get; set; }

        [Required]
		[StringLength(500)]
		public string Id { get; set; }

        [ForeignKey("Resource")]
		[Required]
		public int RowidResource { get; set; }

        [ForeignKey("Culture")]
		[Required]
		public int RowidCulture { get; set; }
        
		[Required]
		public virtual Resource Resource { get; set; }
		[Required]
		public virtual Culture Culture { get; set; }
    }
}