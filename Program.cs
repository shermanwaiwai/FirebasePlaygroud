using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Firebase.Database.Query;
using FirebasePlayground.Model;

namespace FirebasePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            execute().Wait();
        }

        public static async Task execute()
        {
            try
            {
                FirebaseClient firebaseClient = new BL.Firebase().client();

                //var match = await firebaseClient
                //  .Child("MATCH_20170816")  // directly find the date.
                //  .OnceAsync<object>();

                var dino = await firebaseClient
              .Child("MATCH")
              .PostAsync(new MATCH("20170816","TEAM A", "TEAM B", 3.2, 3, 3, 1.8, 1.9));

                var MATCHS = await firebaseClient
                  .Child("MATCH")
                  .OnceAsync<dynamic>();

                var result = MATCHS.Where(x => x.Object["DATE"] == "20170816");

                foreach(var MATCH in MATCHS)
                {
                    Console.WriteLine(MATCH.Object["HOME_TEAM"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
