string[] nomes = new string[10];//array tamanho 10 - de 0 a 9
float[] saldos = new float[10];//array tamanho 10 - de 0 a 9
int totalClientes = 0;//controle a quantidade de cadastros

int opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"=== SISTEMA BANCÁRIO SIMPLES ===
1. Cadastrar Cliente
2. Depositar
3. Sacar
4. Transferir
5. Listar Clientes
0. Sair");
    Console.Write($"Digite a opção: ");
    opcao = int.Parse(Console.ReadLine());

    // switch
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa ...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
       case 5:
        ListarCliente():
        break; 
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }//fim do switch

    //ao final de cada opção, faz uma parada no sistema
    
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();

} while (opcao != 0);
//fim do programa

// Funções

void CadastrarCliente()
{
    // validar se há espaço pra cadastrar no array
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido!");
        return;// para função aqui - não execute o código abaixo
    }

    // cadastrar o cliente no array - 0 
    Console.Write($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();//cadastra o nome do cliente
    saldos[totalClientes] = 0;//inicia o saldo zerado
    totalClientes++;//incrementa a variável de controle de clientes
    Console.WriteLine("Cliente cadastrado com sucesso!");
}

void Depositar()
{
    //retornar onde o cliente está armazenado 
    //assim posso usar de base para guarder de base para o cliente
    int idCliente = BuscarCliente();

    if (idCliente == -1);
    {
        return;//para a função
    }
    Console.WriteLine($"Valor para depósito: ");
    floar valor = float.Parse(Console.ReadLine());
    saldos[idCliente($"Depósito de R$ {valor:F2} realizado")];
}
void Sacar()
{
    int idCliente = BuscarCliente();//buscar o cliente (lista e devolve o id do cliente)
    if (idCliente == -1)
    {//cliente não existe
        return; 
    }

    //cliente existe 
    Console.Write($"Valor para saque: ");
    float valor = float.Parse(Console.ReadLine();)//armazena o valor do saque na variavel valor 

    //se o saldo do cliente for maior ou igual ao valor 
    if(saldo [idCliente] >= valor)
    {//tem saldo suficiente, então pode sacar
        saldos[idCliente] >= valor; //debita o valor da conta/saldo do cliente
        
        Console.WriteLine($"Saque realizado com sucesso!");
    }
    else 
    {
        Console.WriteLine($"Saldo insuficiente!");
    }

}//fim da função Sacar
{
   

        
}
void Transferir()
{
    Console.WriteLine($"== Transferência==");
    Console.Write($"Conta de origem: ");
    int idOrigem = BuscarCliente();
    //cliente não existe 
    if(idOrigem == -1) return;//cliente não existe

    Console.Write($"Conta de Destino":);
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;//cliente não existe 
    Console.Write($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());

    if(Saldo[idDestino] >= valor)
    {
        //transfere de boa 
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor; 
        Console.WriteLine($"ransferência concluída!");
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!");
    }
}
void ListarCliente()

int BuscarCliente()
{
    // listar cliente 
    ListarCliente();//mostra a lista de clientes 
    //pedir pro usuário escolher o cliente 
    Console.WriteLine($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.Write($"Cliente não encontrado!");
        return -1;
    }
    //retornar/devolver o id do cliente 
    return idCliente; 
  }

// criar uma estrutura switch case chamando uma função para cada opção, que exiba apenas uma mensagem