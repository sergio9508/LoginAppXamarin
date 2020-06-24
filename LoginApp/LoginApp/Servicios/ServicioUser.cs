using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using LoginApp.Clases;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LoginApp.Servicios
{
    public class ServicioUser
    {
        public static async Task<Session> Login(User user)
        {
            var url = $"https://node-auth-xamarin.herokuapp.com/api/auth/signin";
            using (var cliente  = new HttpClient())
            {
                var peticion = await cliente.PostAsync(url, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
                if (peticion != null)
                {
                    var json = peticion.Content.ReadAsStringAsync().Result;
                    var datos = (JContainer)JsonConvert.DeserializeObject(json);
                    if (datos["message"]!=null)
                    {
                        string message = (string)datos["message"];
                        Session session = new Session();
                        session.isActive = false;
                        session.errors = message;
                        return session;
                    }else if (datos["accessToken"] != null)
                    {
                        string message = (string)datos["accessToken"];
                        Session session = new Session();
                        session.isActive = true;
                        session.token = message;
                        session.errors = null;
                        return session;
                    }
                }
            }
            return default;
        }
    }
}
