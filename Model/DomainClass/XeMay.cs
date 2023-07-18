using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace hoangpdph31561_CSharp_3_BaiTap_1.DomainClass;

[Table("XeMay")]
public partial class XeMay
{
    [Key]
    [Column("idXeMay")]
    public Guid IdXeMay { get; set; }

    [Column("tenXeMay")]
    [StringLength(50)]
    public string? TenXeMay { get; set; }

    [Column("giaNhap")]
    public int? GiaNhap { get; set; }

    [Column("soLuong")]
    public int? SoLuong { get; set; }

    [Column("moTa")]
    [StringLength(100)]
    public string? MoTa { get; set; }

    [Column("idLoaiXe")]
    public Guid? IdLoaiXe { get; set; }

    [ForeignKey("IdLoaiXe")]
    [InverseProperty("XeMays")]
    public virtual LoaiXe? IdLoaiXeNavigation { get; set; }
}
