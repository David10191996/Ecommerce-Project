using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Global.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDK.Shared.Entities
{
    public abstract partial class BaseMaster<T, U>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Rowid { get; set; }
        public virtual U Id { get; set; }

		[Required]
		[StringLength(250)]
		public virtual string Name { get; set; }

		[Required]
		[StringLength(2000)]
		public virtual string Description { get; set; }

        [Required]
		public virtual enumStatusBaseMaster Status { get; set; }

        public virtual Int64 GetRowid()
        {
            return Convert.ToInt64(Rowid);
        }

        public virtual void SetRowid(Int64 rowid)
        {
            Rowid = (T)Convert.ChangeType(rowid, typeof(T));
        }

        public override string ToString()
        {
            return $"({Id}) - {Name}";
        }

    }
}