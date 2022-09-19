using Common.Models;

int op;
bool continuar=true;
Carro carro = new Carro();
Estacionamento estacionamento =  new Estacionamento();
estacionamento.ListaCarros = new List<Carro>();

do{
    Console.WriteLine("\n");
    Console.WriteLine("ESTACIONAMENTO-DIO");
    Console.WriteLine("DIGITE A OPÇÃO DESEJADA");
    Console.WriteLine("1- Cadastrar a entrada de um veículo");
    Console.WriteLine("2- Cadastrar a saída de um veículo");
    Console.WriteLine("3- Ver a listagem dos veículos");
    Console.WriteLine("4- Sair");
    op = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");
    switch(op){
        case 1:{
            carro.CadastrarPlacaDoCarro();
            carro.CadastrarCorDoCarro();
            carro.CadastrarHoras();
            estacionamento.AdicionarCarro(carro);
        }; break;
        case 2:{
            Console.WriteLine("Digite a vaga do veículo que irá sair");
            estacionamento.ListarCarros();
            estacionamento.RemoverCarro(int.Parse(Console.ReadLine()));
        }; break;
        case 3:{
            estacionamento.ListarCarros();
        }; break;
        case 4: continuar = false; break;
        default:{
            Console.WriteLine("OPÇÃO INVÁLIDA! TENTE NOVAMENTE!\n");
        } break;
    }
    Console.WriteLine("\n");

}while(continuar);
