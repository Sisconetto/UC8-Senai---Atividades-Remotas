//  A empresa Savinis, focada no desenvolvimento de software de alta performance, contratou você para realizar a programação de um sistema de controle de alunos de uma escola. O sistema deverá funcionar da seguinte forma:
//  Considere a quantidade de alunos presentes na sala, percorra do zero até o número total de alunos e retornar os seguintes resultados:
//  - se o número for par, escreva 'par' e o número correspondente.
//  - se o número for ímpar, escreva 'ímpar' e o número correspondente.
//  - se o número for zero, escreva 'zero' e o número correspondente.
//  Para criação desse sistema de cadastro, você, enquanto programador(a) responsável, deverá solucionar os seguintes desafios:
//  Aplicar técnicas de programação e ferramentas para desenvolvimento do código.
//  Aplicar linguagem de programação JavaScript para implementação do sistema.

using System;
using System.Collections.Generic;

class Principal {
    static void Main(){
        Console.Write(" Digite a quantidade de alunos existentes na sala ");

        int alunos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= alunos; i++)
            {
                if (i%2 == 0 && i != 0)
                {
                    Console.WriteLine(" O número " + i + " é par ");   
                }
                else if (i%2 == 1 && i != 0)
                {
                    Console.WriteLine(" O número " + i + " é ímpar ");   
                }
                else if (i == 0)
                {
                    Console.WriteLine(" O número " + i + " é zero");  
                }
            
            }

        Console.ReadKey();
                
    }
    

}