﻿using System;

class Program{

    static void Main(){
        //Cria um menu simples para navegação entre os testes.
        Console.WriteLine("Teste de mesa. Digite a opção desejada:" +
        "\n--Exercicio 1 --"+
        "\n1) Primeiro teste" +
        "\n2) Segundo teste"+
        "\n3) Terceiro teste"+
        "\n--Exercicio 2--" +
        "\n4) Primeiro teste"+
        "\n5) Segundo teste"+
        "\n6) Terceiro teste");

        //lê a entrada do teclado e a converte para int32
        int index = Convert.ToInt32(Console.ReadLine());

        //Define que código executar a depender da entrada.
        switch(index){
            case 1:
                Console.WriteLine("Resultado:");
                TesteDeMesa1.First();
                break;

            case 2:
                Console.WriteLine("Resultado:");
                TesteDeMesa1.Second();
                break;

            case 3:
                Console.WriteLine("Resultado:");
                TesteDeMesa1.Third();
                break;
            case 4:
                TesteDeMesa2.First();
                break;
            case 5:
                TesteDeMesa2.Second();
                break;

            case 6: 
                TesteDeMesa2.Third();
                break;

            case 7:
                TesteDeMesa2.Fourth();
                break;
        }



    }
}
