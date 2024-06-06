using System;

public class Program
{
    public static void Main(string[] args)
    {
        CadastroCliente cadastro = new CadastroCliente();

        int op;
        string nome, cpf;
        int idade;

        Console.WriteLine("----- Cadastro de Clientes -----");

        while (true)
        {
            Console.WriteLine("\nSelecione uma opcao:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Buscar cliente por nome");
            Console.WriteLine("0 - Sair");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Insira a seguir os dados do cliente:");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();

                    Console.Write("\nCPF: ");
                    cpf = Console.ReadLine();
                    if (cpf.Length != 11)
                    {
                        Console.WriteLine("CPF deve conter 11 digitos!");
                        continue;
                    }
                    
                    if (!cpf.All(char.IsDigit)) {
                        Console.WriteLine("CPF deve conter apenas numeros!");
                        continue;
                    }

                    Console.Write("\nIdade: ");
                    string x = Console.ReadLine();
                    if (!x.All(char.IsDigit))
                    {
                        Console.WriteLine("Idade deve conter apenas numeros!");
                        continue;
                    }
                    else
                    {
                        idade = int.Parse(x);
                    }

                    Cliente cliente = new Cliente(nome, cpf, idade);
                    cadastro.adicionarCliente(cliente);
                    break;

                case 2:
                    cadastro.listarClientes();

                    break;

                case 3:
                    Console.Write("Insira o nome a ser buscado: ");
                    nome = Console.ReadLine();
                    cadastro.buscarCliente(nome);

                    break;

                case 0:
                    Console.WriteLine("Finalizando programa!\n");
                    return;
            }
        }
    }
}