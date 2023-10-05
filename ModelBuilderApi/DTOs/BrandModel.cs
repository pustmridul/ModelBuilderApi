using System.ComponentModel.DataAnnotations;

namespace ModelBuilderApi.DTOs
{
    public class BrandModel
    {
        public bool afawf()
        {
            var result = new BrandVm();
            result.Data = new BrandReq();
            result.HasError = false;
            result.Message.Add("DJKBVHDRIKGV");
            result.Message.Add("JKVBEDVGBE");
            return true;
        }
    }
    public class BrandReq
    {
        public string CODE { get; set; }
        public string BRAND_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string IMAGE_URL { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
    public class BrandVm : ResObj
    {
        public BrandReq Data { get; set; }
    }
    public class BrandListVm : ResObj
    {
        public int DataCount { get; set; }
        public List<BrandReq> DataList { get; set; }
    }


}
