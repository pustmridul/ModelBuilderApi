﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("VEHICLE")]
    public class VEHICLE
    {
        [Key]
        public string CODE { get; set; }
        public string? REG_NO { get; set; }
        public string? CHASSIS_NO { get; set; }
        public string? MODEL_NO { get; set; }
        public DateTime? ENROLL_DT { get; set; }
        public string? DRIVER_NAME { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
    }
}
