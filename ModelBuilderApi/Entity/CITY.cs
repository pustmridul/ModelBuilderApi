using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class City
    {
        public string CODE { get; set; }
       
        public string CITY_NAME { get; set; }
    }
}
