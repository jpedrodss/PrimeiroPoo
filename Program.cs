using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personagem toninho = new Personagem();
            toninho.nome = "toninho do celta";
            toninho.idade = 18;
            toninho.armadura = 999;

            Console.WriteLine("O "+ toninho.nome +" tá novo, com apenas: " +toninho.idade +" anos e buffado com: " +toninho.armadura +" Pontos de Armadura.");
            Console.WriteLine(toninho.Atacar(30, 20));

            
        }

    }
}
