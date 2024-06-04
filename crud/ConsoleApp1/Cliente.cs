using System;

public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public int Idade { get; set; }

    public Cliente(string nome, string cpf, int idade) {
        Nome = nome;
        CPF = cpf;
        Idade = idade;
    }
}