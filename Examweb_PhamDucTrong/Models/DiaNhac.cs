using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examweb_PhamDucTrong.Models
{
    public class DiaNhac
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string TuaCD { get; set; }
        [StringLength(50)]
        public string NgheSi { get; set; }
        [Required]
        public bool TrongNuoc { get; set; }
        [Required]
        public double GiaBan { get; set; }
        [Required]
        public int SoLuong { get; set; }
    }
}
