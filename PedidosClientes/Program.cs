using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using SistemaCarros;

// using SistemaCarros;
// bool menu = true;

// while (menu)
// {
//     // Instancia para Cliente
//     Cliente cliente = new();
//     Dictionary<string, string> pedidos = new();
//     // Coleta dados do cliente
//     Console.Write("DIGITE O NOME COMPLETO DO CLIENTE: ");
//     cliente.Nome = Console.ReadLine();

//     Console.Write("DIGITE O TELEFONE DO CLIENTE: ");
//     cliente.Telefone = Convert.ToInt64(Console.ReadLine());


//     // Coleta dados do veiculo do cliente
//     Console.Write("DIGITE O NOME DO VEÍCULO DO CLIENTE: ");
//     cliente.NomeCarro = Console.ReadLine();
//     Console.Write("DIGITE O MODELO DO VEÍCULO: ");
//     cliente.ModeloCarro = Console.ReadLine();
//     Console.Write("DIGITE O ANO DO VEÍCULO: ");
//     cliente.AnoCarro = Convert.ToInt32(Console.ReadLine());
//     // Mostra os dados do cliente armazenados na classe Cliente
//     cliente.MostrarDados();

//     Console.Write("");

//     Console.Write("DESEJA FAZER UM PEDIDO PARA ESTE CLIENTE ['S' para SIM e 'N' para NAO]? ");
//     string? escolha = Console.ReadLine()?.ToUpper();
//     if (escolha == "S")
//     {   
//         // Monta uma lista de pedido para o cliente que acabamos de cadastrar
//         List<Produtos> ListaProdutos = new();
//         Produtos produtos= new();
//         ListaPedido listaPedido = new();

//         listaPedido.Pago(produtos);

//         Console.Write("CÓDIGO DO PRODUTO: ");
//         produtos.CodigoProduto = Convert.ToInt32(Console.ReadLine());

//         Console.Write("NOME DO PRODUTO: ");
//         produtos.NomeProduto = Console.ReadLine();

//         ListaProdutos.Add(produtos);

//         Console.Write("\nPEDIDO CADASTRADO:");
//         cliente.MostrarDados();

//         DateTime date = DateTime.Now;

//         foreach (var produto in ListaProdutos)
//         {
//             Console.WriteLine($"CÓDIGO DO PRODUTO: {produto.CodigoProduto}".ToUpper());
//             Console.WriteLine($"NOME DO PRODUTO: {produto.NomeProduto}".ToUpper());
//             Console.Write("DATA DO PEDIDO: ");
//             Console.WriteLine(date.ToString("dd/MM/yy HH:mm"));
//             //listaPedido.ProdutoPago();
//             Console.WriteLine("X-------------------------------------------------------------------------------------------X");
//         }

//     }
//     if (escolha == "N")
//     {
//         return;
//     }
// }
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Reflection;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("INICIAR PROGRAMA ['S' ou 'N']: ");
        string iniciar = Console.ReadLine().ToUpper();

        if (iniciar == "S")
        {
            Cliente cliente = new Cliente("Ricardo", "Pardim", 31999999999, "Astra", "Advantage", 2007);

            cliente.MostrarDados();

            bool menuPlacas = true;

            while (menuPlacas)
            {
                Dictionary<string, string> placas = new();
                // placas.Add("MG", "ASJ8J90" );
                // placas.Add("SP", "ERJ9S012");

                Console.Write("\nDeseja adicionar alguma placa ['S' ou 'N']: ");
                string adicionar = Console.ReadLine().ToUpper();

                if (adicionar == "S")
                {
                    // Mantém o menu de adicionar e remover placas ativo
                    bool menuAdicionar = true;

                    while (menuAdicionar)
                    {
                        // Pede o usuário para adicionar a 'chave'
                        Console.Write("\nDigite uma key de placa que deseja adicionar: ");
                        var keyPlaca = Console.ReadLine().ToUpper();

                        // Confere se no Dictionary <placas> existe a 'chave/key' digitada na variável 'keyPlaca'
                        if (placas.ContainsKey(keyPlaca))
                        {
                            // Caso exista, lança esta mensagem
                            Console.WriteLine($"\nID de placa ({keyPlaca}) já existente");
                        }
                        else
                        {
                            // Caso não exista, lança esta mensagem, mas não adiciona ainda pois precisa do 'value' junto
                            Console.WriteLine($"\nID de placa '{keyPlaca}' adicionado com sucesso!");
                        }

                        // Pede o usuário para adicionar o 'value'
                        Console.Write("\nDigite a placa que deseja adicionar: ");
                        var valuePlaca = Console.ReadLine().ToUpper();

                        // Confere se no Dictionary <placas> existe o 'value/valor' digitada na variável 'valuePlaca'
                        if (placas.ContainsValue(valuePlaca))
                        {
                            // Caso exista, lança esta mensagem
                            Console.WriteLine($"\nEsta placa ({keyPlaca}) já existe.");
                        }
                        else
                        {
                            // Caso não exista, adiciona no Dictionary <placas>, e lança esta mensagem
                            placas.Add(keyPlaca, valuePlaca);
                            Console.WriteLine($"\nPlaca '{valuePlaca}' adicionada com sucesso!");
                        }

                        Console.Write("\nDeseja adicionar outra placa ['S' ou 'N']: ");
                        string confirmar = Console.ReadLine().ToUpper();

                        if (confirmar == "S")
                        {
                            menuAdicionar = true;
                        }
                        else if (confirmar == "N")
                        {
                            menuAdicionar = false;
                        }
                    }
                }
                else if (adicionar == "N")
                {
                    menuPlacas = false;
                }

                foreach (var placa in placas)
                {
                    // Mostra a lista de placas existentes no Dictionary <placas>
                    Console.WriteLine("PLACA: ");
                    Console.WriteLine(placa);
                }


                bool menuRemover = true;

                while (menuRemover)
                {
                    Console.Write("\nDeseja remover alguma placa ['S' ou 'N']: ");
                    var remover = Console.ReadLine().ToUpper();

                    if (remover == "S")
                    {
                        Console.Write("\nDigite uma key da placa que deseja remover: ");
                        var placaRemovida = Console.ReadLine().ToUpper();

                        if (placas.ContainsKey(placaRemovida) || placaRemovida == null || placaRemovida == "")
                        {
                            placas.Remove(placaRemovida);
                            Console.WriteLine($"\nPlaca '{placaRemovida}' removida com sucesso!");
                            foreach (var placa in placas)
                            {
                                Console.WriteLine("PLACA: ");
                                Console.WriteLine($"{placa}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\nPlaca '{placaRemovida}' não encontrada.");
                        }
                        menuRemover = true;
                    
                    }
                    else if (remover == "N")
                    {
                        menuRemover = false;
                    }
                }
                
                foreach (var placa in placas)
                {
                    Console.WriteLine("PLACA: ");
                    Console.WriteLine(placa);
                }

                try
                {
                    Console.WriteLine("\nVOCÊ DESEJA ENCERRAR O PROGRAMA  ['S' ou 'N']: ");
                    string encerrar = Console.ReadLine();

                    if (encerrar == "S")
                    {
                        break;
                    }
                    else if (encerrar == "N")
                    {
                        menuPlacas = true;
                    }
                } catch (Exception error) {
                    Console.Write($"\nCOMANDO INVÁLIDO. {error}");
                }
            }
        }
        else if (iniciar == "N")
        {
            return;
        }
    }
}