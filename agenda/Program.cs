using System.Data.Common;

Console.Clear();
//Limpando o console
DateTime dataAtual = DateTime.Now;
//Criando um objeto instanciado a parti da classe DateTime e utilizando o Now para já retornar a data atual
Console.WriteLine($"Personalize a sua agenda do dia: {dataAtual.ToString("dd/MM/yyyy")}");
//toString foi utilizado para exibir somente a data, pois o dataAtual traz a data + a hora (retorno do Now).