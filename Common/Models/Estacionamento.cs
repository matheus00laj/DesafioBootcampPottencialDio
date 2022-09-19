using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Common.Models
{
    public class Estacionamento
    {
        public List<Carro> ListaCarros { get; set; }


        public void AdicionarCarro(Carro carro){
            if(carro.Cor != null && carro.Horas != 0 && carro.Placa!= null){
                ListaCarros.Add(carro);
                Console.WriteLine("Cadastro efetuado com sucesso!!!\n");
            }
            else{
                Console.WriteLine("Erro no cadastro. Tente novamente!!");
            }
        }
        
        public void RemoverCarro(int index){
            int contador=0;
            index--;
            Carro indexCarroRemover = new Carro();
            foreach(Carro indexCarro in ListaCarros){
                if(index==contador){
                    indexCarroRemover = indexCarro;
                    break;
                }
                contador++;
            }
            ListaCarros.Remove(indexCarroRemover);
        }
        public void ListarCarros(){
            int quantidade = 0;
            foreach(Carro lista in ListaCarros){
                Console.WriteLine($"{quantidade+1} - {lista.Placa},{lista.Cor}, R${lista.Horas}");
                quantidade++;
            }
        }

    }
}