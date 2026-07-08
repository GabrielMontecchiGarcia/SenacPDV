using System;
using System.Collections.Generic;
using System.Text;

namespace SenacPDV.Models
{
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string Tipo { get; set; } = string.Empty; 
        public int Quantidade { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public DateTime DataMovimentacao { get; set; } = DateTime.UtcNow;
        public int UsuarioId { get; set; }
        public string? Motivo { get; set; }
        public int? ReferenciaVendaId { get; set; }  
       
        public Produto? Produto { get; set; }
        public User? User { get; set; }
    }
}
