using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace hoangpdph31561_CSharp_3_BaiTap_1.DomainClass;

[Table("LoaiXe")]
public partial class LoaiXe
{
    [Key]
    [Column("idLoaiXe")]
    public Guid IdLoaiXe { get; set; }

    [Column("tenLoaiXe")]
    [StringLength(50)]
    public string? TenLoaiXe { get; set; }

    [InverseProperty("IdLoaiXeNavigation")]
    public virtual ICollection<XeMay> XeMays { get; set; } = new List<XeMay>();
}
