using System; 
using System.Collections.Generic;

class Principal {
    static void Main(){

        List<string> ListaDePecas = new List<string>() { "Filtro de Ar","Motor","Amortecedor"};

        if (ListaDePecas.Count <= 10){ // ListaDePecas.Count serve para verificar quantos itens existem dentro da lista

            Console.Write("Digite o peso da peça : ");
            double peso = Convert.ToDouble(Console.ReadLine()); // Por padrão o ConsoleReadline recebe por string, no caso como é double peso, precisava fazer essa conversao Convert.ToDouble
            
            if (peso > 100){

                    Console.Write("Qual é o nome da peça ? : ");
                    string nome = Console.ReadLine();
                    
                        if (nome.Length <= 3){
                            Console.Write("Nome de peça inválido, ele tem que ser maior que 3 caracteres : ");
                        } else {
                         ListaDePecas.Add(nome);
                         ListaDePecas.ForEach(Console.WriteLine); // Para mostrar os itens da lista, deve-se percorrer todos estes para printa-lo no WriteLine
                        }
            
            } else {
                    Console.Write("Peso menor que o permitido, cadastramento não autorizado !");
            }     
     
        } else { 
            Console.Write("Lista cheia, não é possível adicionar mais elementos !");
            }
        
    Console.ReadKey();
    }
}
