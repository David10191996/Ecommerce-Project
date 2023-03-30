using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public abstract class BaseEntity<T>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public virtual T Rowid { get; set; }
    public virtual Int64 GetRowid()
    {
        return Convert.ToInt64(Rowid);
    }
    public virtual void SetRowid(Int64 rowid)
    {
        Rowid = (T)Convert.ChangeType(rowid, typeof(T));
    }

}