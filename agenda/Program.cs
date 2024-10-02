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
