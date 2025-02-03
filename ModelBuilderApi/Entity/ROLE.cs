using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class ROLE
    {
       
        public string ROLE_NAME { get; set; }
        public string? DESCRIPTION { get; set; }
    }
}
