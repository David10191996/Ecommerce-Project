using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SDK.Shared.Entities
{
    public partial class State : BaseMaster<int, string>
    {
   
        [Key]
		[Required]
		public override int Rowid { get; set; }

		[Required]
		[StringLength(10)]
		public override string Id { get; set; }

		[ForeignKey("Country")]
		[Required]
		public int RowidCountry { get; set; }

		[Required]
		public virtual Country Country { get; set; }
    }
}