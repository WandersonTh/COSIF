using System;
using System.ComponentModel.DataAnnotations;

namespace COSIF.Api.Models
{
    public class Movimento_Manual
    {
        [Key]
        public int NUM_LANCAMENTO { get; set; }        
        public int DAT_MES { get; set; }        
        public int DAT_ANO { get; set; }             
        public string COD_PRODUTO { get; set; }        
        public string COD_COSIF { get; set; }
        public string DES_DESCRICAO { get; set; }
        public DateTime DAT_MOVIMENTO { get; set; }
        public string COD_USUARIO { get; set; }
        public double VAL_VALOR { get; set; }
    }
}
