﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PRODUCT_BOM")]
    public class PRODUCT_BOM
    {
        [Key]
        public string BARCODE { get; set; }
        [Key]
        public string ING_BARCODE { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public string? USER_BARCODE { get; set; }
        public decimal QTY { get; set; }
        public string? ING_USER_BARCODE { get; set; }
        public decimal ING_QTY { get; set; }

    }
}
