using FireSharp.Interfaces;
using FireSharp.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  
    
    public class CD_Conexion
    {
   
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "xzjgjgb61WnrufFhXQV3OYXtFDsWIGyFXuGgK6Wp",
            BasePath = "https://sistemasolis-6c075-default-rtdb.firebaseio.com/"
           
        };

        public IFirebaseClient Abrir()
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            return client;
        }
       
        

            
    }
}
