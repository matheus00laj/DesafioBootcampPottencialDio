using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Carro
    {
        public Carro(){

        }
        public Carro(string placa, string cor){
            Placa = placa;
            Cor = cor;
        }
        
        private string _cor;
        private string _placa;
        private decimal _valor;

        public string Cor{
            get => _cor;

            set{
                if(value == ""){
                    throw new ArgumentException("O campo do modelo não pode estar vazio!");
                }
                _cor = value;
            }
        }
        public string Placa{
            get => _placa;

            set{
                if(value == ""){
                    throw new ArgumentException("O campo da placa não pode estar vazio!");
                }
                else if(value.Length >7){
                    throw new ArgumentException("O campo da placa não pode ser maior que 7 dígitos");
                }
                for(int i = 0; i < value.Length; i++){
                    string simbols = "/*-+.,|!@#$%¨&*()_+={}[]`^~;:'°¹²³£¢¬₢ ";
                    for(int index=0; index<simbols.Length; index++){
                        if(value[i]==simbols[index]){
                            throw new ArgumentException("A placa não pode conter caracteres especiais. Apenas Letras e números.");
                        }
                    }
                }
                _placa = value;
            }
        }
        public decimal Horas{
            get => _valor;
            set{
                
                if(value < 1 || value>24){
                    throw new ArgumentException("Você não pode ficar menos de 1 hora ou mais de 24 horas no estacionamento");
                }
                _valor =  value * 7;
            }
            

        }

        public void CadastrarPlacaDoCarro(){
            Console.WriteLine("Digite a placa do carro (Max. 7 caracteres)");
            Placa = Console.ReadLine();
        }
        public void CadastrarCorDoCarro(){
            Console.WriteLine("Digite a cor do carro");
            Cor = Console.ReadLine();
        }
        public void CadastrarHoras(){
            Console.WriteLine("Digite o tempo que o carro irá ficar no estacionamento");
            Console.WriteLine("Min: 1h; Max: 24h");
            Console.WriteLine("R$ 07,00");
            Horas = decimal.Parse(Console.ReadLine());
        }

    }
}