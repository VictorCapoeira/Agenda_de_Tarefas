using System.Net.Http;
using System.Threading.Tasks;
//Nas linhas acima, bibliotecas foram chamadas. A primeira será usada para trabalhar com http(url, se for mais facil). Usando essa biblioteca, será possivel fazer requesições http. A segunda será usada para trabalhar em conjunto com a API de clima, pois utilizando essa biblioteca, será possivel gerar uma melhor dinamica com ela. Já que, com essa biblioteca, é possivel alterar o tempo de "reposta" que a aplicação espera. Como uma API será carregada nesse site, essa biblioteca é interresante, pois pode ocorrer de os dados ou requesições feitas a API podem demorar. 
class Program{
    private static readonly HttpClient client = new HttpClient();
    //Private == Definindo o "nivel de acesso". Usando private, é restrigir o acesso somente para dentro da classe que a variavel(client) foi criada. static == Basicamente, esse comando indica que a variavel é compartilhada para todas as istancias da classe, ou seja, indepentende do que ocorra, essa variavel irá permancer "estatica". readonly == Desse modo, é garantido que a variavel só pode ter seu valor atribuido quando é criada. HttpClient client = new HttpClient() == Signfica que um objeto client está sendo instanciado da classe HttpClient, desse modo será possivel usar os metodos da classe. 
    private const string apiKey = "8fd60c011e18a1e39ca92181f751f128";
    //const é usado para garantir que o valor dessa variavel não vá ser alterado futuramente, pois usando const, só é possivel atribuir um valor para a variavel quando ela é criada. Foi feito desse modo para gerar mais segurança(sobre a key correta).
    //A variavel apiKey foi criada para guarda a chave de acesso da API de clima.
    private const string apiUrl = "https://api.openweathermap.org/data/2.5/weather";
    //Para conseguir ter acesso a API é preciso passar a chave dela e a URL. 

     static async Task Main(string[] args){
        Console.WriteLine("CLIMATICO");
        Console.Write("Digite o nome da cidade: ");
        string cidade = Console.ReadLine();
        //Acima, um texto de referencia foi escrito, solicitando a cidade que o usuario deseja fazer a pesquisa, e logo em seguida, foi coletado esse valor e armazenado na variavel cidade.
        var weatherData = await GetWeatherAsync(cidade); 
        //usando var, faz com que o compilador passe a deduzir o tipo de variavel que será retornado pelo metodo. await é uma palavra chave utilizado para indicar que a execução do código deve esperar a conclusão da tarefa(GetWeatherAsync) para avanaçar, assim previnindo erros. GetWeatherAsync(cidade) é metodo que vai buscar os dados climaticos a parti da API. Passamos a cidade que o usuario passou como parametro.
     }
    static async Task<string> GetWeatherAsync(string city) {
        string url = $"{apiUrl}?q={city}&appid={apiKey}&units=metric"; 
        //criando a variavel que irá fazer a requesição de dados para a API.
        var response = await client.GetStringAsync(url); 
        // a variavel response irá guardar os dados da requesição gerados acimna.
        return response;
        //Linha para retornar o resultado para o metodo.(ou seja, quando o metodo for chamado, ele terá o response como resultado de reposta)
    } 
    
     

}