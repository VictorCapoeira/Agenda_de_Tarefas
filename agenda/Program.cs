using System.Data.Common;

Console.Clear();
//Limpando o console
DateTime dataAtual = DateTime.Now;
//Criando um objeto instanciado a parti da classe DateTime e utilizando o Now para já retornar a data atual
Console.WriteLine($"Personalize a sua agenda do dia: {dataAtual.ToString("dd/MM/yyyy")}");
//toString foi utilizado para exibir somente a data, pois o dataAtual traz a data + a hora (retorno do Now).

int esc = 0;
//Criando variavel para conter a escolha do usuario
bool escVer = false;
//Criando variavel para validar se a reposta do user foi satisfatoria
do{
    Console.WriteLine("Opções: 1- Gerenciar Tarefas 2- Visualizar Tarefas");
    //Exibindo opções para o usuario
    if(int.TryParse(Console.ReadLine(), out esc) && (esc <= 2 && esc >= 1))
        escVer = true;
    //Criando um loop que vai ficar repetindo até que o usuario satisfaça a condição
}while(escVer == false);



