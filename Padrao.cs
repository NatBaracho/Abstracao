using System;

abstract class Padrao
{
    //obrigatório
    public abstract void taxaEmprestimo(double valor);

    //opcional

    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine($"Ganhos Gerados pela Poupança: {valor * taxa:C}");
    }
}