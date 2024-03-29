﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable enable
#nullable disable warnings

namespace VNPT_Review.Models
{
    public partial class Office
    {
        [Key]
        [Required(ErrorMessage = "{0} không được để trống.")]
        [Display(Name = "Mã phòng ban")]
        [StringLength(5)]
        public string Id { get; set; }

        [Required(ErrorMessage = "{0} không được để trống.")]
        [Display(Name = "Tên phòng ban")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Ghi chú")]
        [StringLength(200)]
        public string? Note { get; set; }

        [Required(ErrorMessage = "Đơn vị cha không được để trống.")]
        [Display(Name = "Đơn vị cha")]
        [StringLength(5)]
        public string FatherId { get; set; }

        [Display(Name = "Hoạt động")]
        public bool Active { get; set; }

        public decimal Rating { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateTime UpdatedAt { get; set; }
    }
    
    public partial class Office
    {
        public int ExistUserReview { get; set; }
        public int TotalCount { get; set; }
        public int FilteredCount { get; set; }
    }
}
