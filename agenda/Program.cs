using System.Collections.Generic;
//Chamando bibliotecas necessarias! No caso, a Collections.Generic está sendo chamada para o "list" ser melhor utilizado.

public class Tarefa{
    public int Id {get; set;}
    public string Nome {get; set;}
    public string Descricao {get; set;}
    public bool Check {get; set;}

    public Tarefa(int id, string nome, string descricao){
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Check = false;
    } 
}

class Program{
    static List<Tarefa> tarefas = new List<Tarefa>();
    static int idProx = 1;
    static bool vef = false;
    static void Main(String[] args){
        do{
            Console.Clear();
            Console.WriteLine("Agenda de Tarefas");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Concluir tarefas");
            Console.WriteLine("4 - Remover tarefas");
            Console.WriteLine("5 - Sair");

            string escolhaAcao = Console.ReadLine();
            /*switch(escolhaAcao){
                //case "1":

            }*/

        }while(vef == false);
    }
}