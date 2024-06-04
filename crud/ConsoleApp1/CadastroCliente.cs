using System;

public class CadastroCliente
{
    private List<Cliente> clientes = new List<Cliente>();

    public void adicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void listarClientes()
    {
        if (clientes.Count != 0)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{cliente.Nome}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum cliente foi encontrado!");
        }
    }

    public void buscarCliente(string nome)
    {
        List<Cliente> clientesEncontrados = new List<Cliente>();

        foreach (var cliente in clientes)
        {
            if (cliente.Nome == nome)
            {
                clientesEncontrados.Add(cliente);
            }
        }

        if (clientesEncontrados.Count != 0)
        {
            foreach (var cliente in clientesEncontrados)
            {
                Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}, Idade: {cliente.Idade}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum cliente foi encontrado!");
        }
    }
}