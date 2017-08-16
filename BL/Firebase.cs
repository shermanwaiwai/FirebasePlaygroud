using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebasePlayground.BL
{
    public class Firebase
    {
        const string url = "https://soccerapp-66b2f.firebaseio.com/";
        public FirebaseClient client()
        {
            return new FirebaseClient(url);
        }
    }
}
