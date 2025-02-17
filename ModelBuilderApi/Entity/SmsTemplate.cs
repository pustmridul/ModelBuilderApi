﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class SmsTemplate
    {
       
        public int Id { get; set; }
        public string? Message { get; set; }
        public bool? Status { get; set; }
        public string StoreCode { get; set; }
        public string CompanyCode { get; set; }
        public string Title { get; set; }
    }
}
