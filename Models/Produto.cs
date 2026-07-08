using System;
using System.Collections.Generic;
using System.Text;

namespace SenacPDV.Models
{
    public class Produto : IHasId
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int EstoqueAtual
        {
            get => Estoque;
            set => Estoque = value;
        }

        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
