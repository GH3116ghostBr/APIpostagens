using APIpostagens.Models;
using System.Text.Json;
using Newtonsoft.Json;


namespace APIpostagens

{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
           InitializeComponent();
        }

        async private void BuscarApi(object sender, EventArgs e)
        {
            Postagem minhaPostagem = new Postagem();

            string URI = "https://jsonplaceholder.typicode.com/posts";

            List<Postagem> postagens = new List<Postagem>();
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);
            postagens = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);


        }
    }
}
