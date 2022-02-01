using System.ComponentModel.DataAnnotations;
namespace COSIF.Api.Models
{
    public class Produto_Cosif
    {
        [Key]
        public string COD_COSIF { get; set; }        
        public string COD_PRODUTO { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }
    }
}
