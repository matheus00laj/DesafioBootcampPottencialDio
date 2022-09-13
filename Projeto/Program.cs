using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Models;


int opcao;
bool continuar= true;
Carro carro = new Carro();
do{
    Console.WriteLine("\n");
    Console.WriteLine("Estacionamento-DIO");
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1- Cadastrar a entrada de um carro");
    Console.WriteLine("2- Ver a lista de carros que entraram");
    Console.WriteLine("3- Remover algum carro");
    Console.WriteLine("4- Sair");
    opcao=int.Parse(Console.ReadLine());
    Console.WriteLine("\n\n");

    switch(opcao){
        case 1:{
            carro.RegistraPlaca();
            carro.RegistraVaga();
            carro.RegistraHoras();
        } break;
        case 2:{
            carro.Listagem();
        } break;
        case 3:{
            carro.Remover();
        } break;
        case 4: {
            continuar = false;
        }break;
        default:{
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("Tente Novamente!\n\n");
        }break;
        

    }

}while(continuar);