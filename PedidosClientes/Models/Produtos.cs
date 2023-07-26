using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCarros
{
    public class Produtos
    // Tudo oque é necessário par cadastrar um produto no pedido do cliente
    {
        public int CodigoProduto { get; set; }
        private string _nomeProduto;
        public string NomeProduto
        {
            get => _nomeProduto;
            set
            {
                if (NomeProduto == "")
                {
                    throw new ArgumentException("O NOME DO PRODUTO ESTÁ VAZIO.");
                }
                _nomeProduto = value;
            }
        }
        public string Fornecedor { get; set; }
        private int _valorProduto;
        public int ValorProduto
        {
            get => _valorProduto;
            set
            {
                if (ValorProduto < 0)
                {
                    throw new ArgumentException("VALOR INVÁLIDO!");
                }
                _valorProduto = value;
            }
        }
        
    }
}