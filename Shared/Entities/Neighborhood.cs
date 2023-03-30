using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDK.Shared.Entities
{
    public partial class Neighborhood : BaseMaster<int, string>
    {
        
		[Key]
		[Required]
		public override int Rowid { get; set; }

		[Required]
		[StringLength(50)]
		public override string Id { get; set; }

		[ForeignKey("City")]
		[Required]
		public int RowidCity { get; set; }


		[Required]
		public virtual City City { get; set; }
    }
}