using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*  static void Main(string[] args)
          {
              Task<int> i = Task.Run(() =>
             {

             }).ContinueWith((Func<Task, int>)((i) =>
                 {
                     return (int)(i.Result * 2);
                 }));
          }
  */



        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
        }
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }

        // PLINQ, Concurrent COllections (Thread safe collections)

    }
}
