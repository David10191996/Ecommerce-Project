using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDK.Shared.Entities
{
    public partial class City : BaseMaster<int, string>
    {
        [Key]
		[Required]
		public override int Rowid { get; set; }

		[Required]
		[StringLength(10)]
		public override string Id { get; set; }

		[ForeignKey("State")]
		[Required]
		public int RowidState { get; set; }


		[Required]
		public virtual State State { get; set; }
        
    }
}