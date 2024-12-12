using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace _13k_konzol_api
{
    class Program
    {
        static List<Sajt> sajtok = new List<Sajt>();
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg mit szeretnél csinálni!");
            Console.WriteLine("get/post/put/delete");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                if (input == "get")
                {
                    readAll();
                    foreach (Sajt item in sajtok)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else if (input == "post")
                {

                }
                else if (input == "put")
                {

                }
                else if (input == "delete")
                {

                }
                Console.WriteLine("Add meg a következő lépésedet");
                input = Console.ReadLine();
            }





            Console.ReadKey();
        }
        static async void readAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = "http://127.123.54.99:3000/sajt";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseMessage = await response.Content.ReadAsStringAsync();
                sajtok = JsonConvert.DeserializeObject<List<Sajt>>(responseMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
