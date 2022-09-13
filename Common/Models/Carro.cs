using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Carro
    {
        public List<string> ListaPlacas = new List<string>();
        public List<int> ListaVagas = new List<int>();
        public List<int> ListaHoras = new List<int>();

        public void RegistraPlaca(){
            bool continuar = true;
            string? placa;
            do{
                Console.WriteLine($"Digite a placa do carro (Max. 7 caracteres)");
                placa = Console.ReadLine();
                if(placa.Length == 7){
                    ListaPlacas.Add(placa);
                    Console.WriteLine("SUCESSO!\n\n");
                    break;
                }
                else{
                    Console.WriteLine("Numero de caracteres inválido!");
                    Console.WriteLine("Todas a placas devem ter 7 dígitos. Por favor, tente de novo!\n");
                }

            }while(continuar);
            
        }
        public void RegistraVaga(){
            bool continuar = true, vagaLivre = false;
            int vaga;
            
            do{
                
                Console.WriteLine($"Escolha o numero da vaga(1 à 20):");
                vaga = int.Parse(Console.ReadLine());

                if(ListaVagas.Count==0 && vaga<=20 && vaga>=1){
                    vagaLivre = true;
                }
                else{
                    for(int i=0; i< ListaVagas.Count; i++){
                    if(vaga == ListaVagas[i]){
                        Console.WriteLine("Esta vaga está ocupada, escolha outra!\n");
                        break;
                    }
                    else if(vaga<=20 && vaga>=1){
                        vagaLivre = true;
                    }
                
                }
                if(vaga<1 || vaga>20){
                    Console.WriteLine("Posição Inválida!\nPor favor, tente novamente!");
                }
                }
                if(vagaLivre){
                    ListaVagas.Add(vaga);
                    Console.WriteLine("SUCESSO!\n\n");
                    break;
                }
            
            }while(continuar);
        }
        public void RegistraHoras(){
            bool continuar = true;
            int horas;
            do{
                Console.WriteLine("Digite quanto tempo seu carro ficará no estacionamento(Min. 1h, Max. 24):");
                horas = int.Parse(Console.ReadLine());
                if(horas>1 && horas<=24){
                    ListaHoras.Add(horas);
                    Console.WriteLine("SUCESSO!\n\n");
                    break;
                }
                else{
                    Console.WriteLine("Tempo Inválido!");
                    Console.WriteLine("O tempo máximo é de 24h e o tempo Mínimo é de 1h");
                    Console.WriteLine("Por favor, tente novamente!\n");
                }
            }while(continuar);
        }

        public void Listagem(){
            decimal valor=9;
            for(int i = 0; i< ListaPlacas.Count; i++){
                Console.WriteLine($" Vaga: {ListaVagas[i]}, Placa: {ListaPlacas[i]}, Horas: {ListaHoras[i]}, Preço:{ListaHoras[i]*valor}");
            }
            Console.WriteLine($"{ListaPlacas.Count} Carros entraram no estacionamento.");
        }
        public void Remover(){
            bool continuar = true;
            int selecaoVaga;
            

            Listagem();
            do{
                Console.WriteLine("Digite qual vaga deseja remover:");
                selecaoVaga = int.Parse(Console.ReadLine());
                for(int i=0; i<ListaVagas.Count; i++){
                    if(ListaVagas[i]==selecaoVaga){
                        ListaVagas.Remove(ListaVagas[i]);
                        ListaPlacas.Remove(ListaPlacas[i]);
                        ListaHoras.Remove(ListaHoras[i]);
                        Console.WriteLine("Carro removido com sucesso!\n\n");
                        Listagem();
                        continuar = false;
                    }
                }

            }while(continuar);
        }
    }
}