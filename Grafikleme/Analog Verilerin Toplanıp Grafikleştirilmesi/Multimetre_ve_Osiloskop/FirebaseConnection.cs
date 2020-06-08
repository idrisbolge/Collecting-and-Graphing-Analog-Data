using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Multimetre_ve_Osiloskop
{
    class FirebaseConnection
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "nhvKyN6uaGwRuOrV5vmzHAIbFBPyfnwvYTAtNG9H",
            BasePath = "https://wificommunication-fe74c.firebaseio.com/"
        };

        public IFirebaseClient client;
        public FirebaseResponse response;



    }
}
