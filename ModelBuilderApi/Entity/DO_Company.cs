using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class DO_Company
    {
        public string Code { get; set; }
        public string CompanyName { get; set; }
        public string ReportFileName { get; set; }
        public string ReportFileNameTwo { get; set; }
    }
}
