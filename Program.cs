using System;
using System.Collections.Generic;
using ExemploLista.Classes;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Produtos> Produtos = new List<Produtos>();

             Produtos.Add(new Produtos(1, "Bugatti La Voiture Noire", 18,000,680f));
             Produtos.Add(new Produtos(2, "Rolls-Royce Sweptail", 12,000,000f));
             Produtos.Add(new Produtos(3, "Koenigsegg CCXR Trevita", 4,000,000f));
             Produtos.Add(new Produtos(4, "Lamborghini Veneno Roadster ", 4,500,000f));
             Produtos.Add(new Produtos(5, "McLaren P1 LM", 3,700,000f));

             
             

        
        }
    }
}
