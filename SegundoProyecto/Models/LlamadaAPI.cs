using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class LlamadaAPI
    {
        public static async Task<List<Book>> FetchBooksAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://potterapi-fedeperin.vercel.app/");
                HttpResponseMessage response = await client.GetAsync("es/books");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<Book> books = JsonConvert.DeserializeObject<List<Book>>(jsonResponse)!;
                    return books!;
                }
                else
                {
                    return null!;
                }
            }
        }
    }
}
