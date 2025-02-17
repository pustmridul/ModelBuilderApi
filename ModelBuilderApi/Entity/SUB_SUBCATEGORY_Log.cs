﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class SUB_SUBCATEGORY_Log
    {
        public string CODE { get; set; }
        public string SUB_SUBCATEGORY_NAME { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? SUB_CATEGORY_CODE { get; set; }
        public string COMPANY_CODE { get; set; }
        public decimal VAT_PERCENT { get; set; }
        public string? IMAGE_URL { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
