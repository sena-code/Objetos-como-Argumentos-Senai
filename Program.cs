using System;

namespace Aula24ObjetoscomoArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto("GTA V",1 , 150.99f);
            Produto p2 = new Produto("The Last of Us part 2",2 , 250f);
            Produto p3 = new Produto("Detroit Become Humam",3 , 99.99f);
            Produto p4 = new Produto("Uncharted 4",4 , 50.99f);
            Produto p5 = new Produto("Dark Souls 2",5 , 75.99f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);
            cart.Adicionar(p5);

            cart.Remover(p1);


            Produto p6 = new Produto("Celeste", 2, 250f);
            cart.Alterar(2, p6);

            cart.Ler();
            cart.MostrarTotal();



        }
    }
}
