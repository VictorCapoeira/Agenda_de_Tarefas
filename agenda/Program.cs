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
            switch(escolhaAcao){
                case "1":
                    Adicionar();
                    break;
                case "2":
                    Listar();
                    break;
                case "3":
                    checkTarefas();
                    break;
                case "4":
                    remover();
                    break;
                case "5":
                    vef = true;
                    return;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;

            }

        }while(vef == false);
    }
    static void Adicionar(){
        Console.WriteLine("Informe o nome da tarefa: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe a descrição da tarefa: ");
        string descricao = Console.ReadLine();
        var tarefa = new Tarefa(idProx++, nome, descricao);
        tarefas .Add(tarefa);
        Console.ReadKey();
    }  
    static void Listar(){
        Console.WriteLine("Tarefas: ");
        foreach(var tarefa in tarefas){
            Console.WriteLine($"{tarefa.Id} - {tarefa.Nome} -- {tarefa.Descricao} -- {(tarefa.Check ? "Concluida" : "Pendente")}");
        }
        Console.ReadKey();
    }  
    static void checkTarefas(){
        Console.WriteLine("Insira o ID da tarefa que deseja marcar como concluida: ");
        if(int.TryParse(Console.ReadLine(), out int id)){
            var tarefa = tarefas.Find(t => t.Id == id);
            if(tarefa != null){
                tarefa.Check = true;
                Console.WriteLine("Tarefa marcada como concluida!");
            }else{
                Console.WriteLine("Tarefa não encontrada. Verifique se a tarefa realmente existe!");
            }
        }else
            Console.WriteLine("ID invalido!");
        Console.ReadKey();
    }  
    static void remover(){
        Console.WriteLine("Insira o ID da tarefa que deseja marcar como concluida: ");
        if(int.TryParse(Console.ReadLine(), out int id)){
            var tarefa = tarefas.Find(t => t.Id == id);
            if(tarefa != null){
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida!");
            }else{
                Console.WriteLine("Tarefa não encontrada. Verifique se a tarefa realmente existe!");
            }
        }else
            Console.WriteLine("ID invalido!");
        Console.ReadKey();
    }  
}
