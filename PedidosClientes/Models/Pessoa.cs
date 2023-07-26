using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarros
{
    public class Cliente
    {   
        // Dados da classe CLasse
        private int _id;
        private string _nome;
        private string _sobrenome;
        public int Id 
        { 
            get
            {
                return _id;
            } 
            set
            {
                if (value != _id)
                {
                throw new ArgumentException("O código de identificação do cliente está incorreto");
                }
                _id = value;
            }
        }
        public string Nome
        { 
            get
            {
                return _nome;
            } 
            set
            {
                if (value == "")
                {
                throw new ArgumentException("O nome do cliente não pode estar vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome
        { 
            get
            {
                return _sobrenome;
            } 
            set
            {
                if (value == "")
                {
                throw new ArgumentException("O nome do cliente não pode estar vazio");
                }
                _sobrenome = value;
            }
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 
        /// <summary>
        /// Uma variável esclusiva para leitura que junta duas variáveis de nome e sobrenome para facilitar junção no Console
        /// </summary>
        public long Telefone { get; set; }
        public string NomeCarro { get; set; }
        public string ModeloCarro { get; set; }
        public int AnoCarro { get; set; }
        public string CarroCliente => $"{NomeCarro} {ModeloCarro} {AnoCarro}".ToUpper();
        /// <summary>
        /// Uma variável esclusiva para leitura que junta duas variáveis de nome e sobrenome para facilitar junção no Console
        /// </summary>
        
        public Cliente(string nome, string sobrenome, long telefone, string nomecarro, string modelocarro, int anocarro)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            // NomeCarro = nomecarro;
            // ModeloCarro = modelocarro;
            // AnoCarro = anocarro;
        }
        public void Deconstruct(out string nome, out string sobrenome, out long telefone)
        {
            sobrenome = Sobrenome;
            nome = Sobrenome;
            telefone = Telefone;
        }
        public void MostrarDados()
        // Método para mostrar os dados do cliente quando precisar
        {
            Console.WriteLine($"");
            Console.WriteLine($"NOME: {NomeCompleto} / TELEFONE: {Telefone} / VEÍCULO: {CarroCliente}\n");

        }
    }
}