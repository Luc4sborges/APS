using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDotnet.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "BANCO")]
        public int Banco { get; set; }
        [Display(Name = "NOME DO BANCO")]
        public string ?NomeDoBanco { get; set; }        
    }
}