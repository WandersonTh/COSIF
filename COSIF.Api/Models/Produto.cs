using System.ComponentModel.DataAnnotations;

namespace COSIF.Api.Models
{
    public class Produto
    {   [Key]     
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }
    }
}
