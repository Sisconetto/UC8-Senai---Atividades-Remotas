using System;
using System.Collections.Generic;

    class Principal{
        static void Main(){

            // Leitura do dia entre 01 a 30

            int ano = 2021;

            Console.Write(" Olá, este é um cadastramento de eventos para 2021" );
            Console.Write("\r\n");     
        
            Console.Write(" Digite o dia (01 a 30) ");
            int dia = Convert.ToInt16(Console.ReadLine());

            // Validação do dia entre 01 a 30

                while (dia <= 0 || dia > 30) // || é OU
                {
                    Console.Write("\r\n"); 
                    Console.Write(" Digite novamente um dia válido ");
                    Console.Write("\r\n");    
        
                    Console.Write(" Digite o dia (01 a 30) ");
                    dia = Convert.ToInt16(Console.ReadLine());       

                }
        
            // Leitura do mês

            Console.Write("\r\n");     
        
            Console.Write(" Digite o mês (01 a 12) ");
            int mes = Convert.ToInt16(Console.ReadLine());

            // Validação do mês de 01 a 12 (Janeiro a Dezembro)

                while (mes <= 0 || mes > 12) // || é OU
                {
                    Console.Write("\r\n"); 
                    Console.Write(" Digite novamente um mês válido ");
                    Console.Write("\r\n");    
        
                    Console.Write(" Digite o mês (01 a 12) ");
                    mes = Convert.ToInt16(Console.ReadLine());       

                }

            // Transformando as datas de entrada em Datetime
            DateTime dataevento = new DateTime(ano, mes, dia);
            Console.Write(" A Data Solicitada é :");
            Console.WriteLine(dataevento.ToString(" dd'/'MM/yyyy "));

            // Criando a lista das datas indisponíveis pré-existentes

            List<String> datasindisponiveis = new List<String>(){"02/12/2021", "03/11/2021", "05/06/2021", "09/12/2021"};
            
            // Comparando se a data digitada se encontra dentro da lista que contém as datas indisponiveis

            if (datasindisponiveis.Contains(dataevento.ToString("dd'/'MM/yyyy"))){
                Console.Write(" A data solicitada encontra-se indisponível - Iniciar Cadastramento novamente ");
                    
            } else {
                Console.Write(" Data disponível - Prossiga com o Cadastro ");

                // Cadastrando Nome
                Console.Write("\r\n");
                Console.Write("Digite o seu nome ");
                string nome = Console.ReadLine();

                // Cadastrando e validando a idade (Proibido Cadastramento menores que 18 anos)

                Console.Write(" Digite a sua Idade :");
                int idade = Convert.ToInt16(Console.ReadLine());

                if (idade < 18){
                    Console.Write(" \r\n Cadastramento não disponíveis para menores de 18 anos ");

                } else {

                    Console.Write(" \r\n Cadastramento realizado com sucesso ");
                    Console.Write(" \r\n");
                    Console.Write(" O Nome : " + nome + "\r\n");
                    Console.Write(" Idade : " + idade + "\r\n");
                    Console.Write(" Data Agendada : " + dataevento.ToString("dd'/'MM/yyyy") + "\r\n");

                    }


            
            }

        Console.ReadKey();

        }


    

    }

