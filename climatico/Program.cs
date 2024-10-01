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

}