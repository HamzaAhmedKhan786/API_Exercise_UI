using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace API_Exercise_UI
{
    public class API
    {
        private string result = string.Empty;
        static string api_address = "https://localhost:7133/api/";
        private User_Data login_user = new User_Data();
        public API()
        {

        }

        static Object Call_Api_Without_Input(string api_name)
        {
            string result_data = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(api_address);

                //HTTP GET
                var responseTask = client.GetAsync(api_address + api_name);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var movies_data = readTask.Result;

                    result_data = readTask.Result;
                }
            }
            return result_data;
        }

        internal void Set_User(User_Data user)
        {
            this.login_user = user;
        }

        internal string Get_User_Collection()
        {
            var result = Call_Api_Without_Input("Movies/" + login_user.email_address);
            return result.ToString();
        }

        private static HttpClient GetHttpClient(string url)
        {
            var client = new HttpClient { BaseAddress = new Uri(url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }


        private static async Task<T> GetAsync<T>(string api_name, string request_params)
        {
            // Initialization.  
            string responseObj = String.Empty;
            try
            {
                using (var client = GetHttpClient(api_address + api_name))
                {
                    var stringContent = new StringContent(request_params, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(api_address + api_name, stringContent);
                    response.Wait();
                    Console.WriteLine(response);
                    if (response.Result.StatusCode == HttpStatusCode.OK)
                    {
                        var json = response.Result.Content.ReadAsStringAsync();
                        json.Wait();
                        var result = JsonConvert.DeserializeObject<T>(json.Result);
                        //return result;
                        responseObj = result.ToString();
                    }
                    else
                    {
                        responseObj = response.Result.StatusCode.ToString();
                    }

                    return (T)Convert.ChangeType(responseObj, typeof(T));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (T)Convert.ChangeType("No connection available", typeof(T));
            }
        }

        internal string Get_All_COllection()
        {
            var result = Call_Api_Without_Input("Movies/");
            return result.ToString();
        }

        public static async Task<T> RunAsync<T>(string api_name, string urlParameters)
        {
            return await GetAsync<T>(api_name, urlParameters);
        }

        internal string Get_all_movies(string user_role)
        {
            var result = Call_Api_Without_Input("Movies/" + user_role);
            return result.ToString();
        }

        internal string Get_User_Login(string user_name, string password)
        {
            Login_User user = new Login_User();
            user.email_address = user_name;
            user.password = password;
            var requestParams = JsonConvert.SerializeObject(user);
            var response = RunAsync<object>("Login", requestParams).GetAwaiter().GetResult();
            Console.WriteLine(response);
            if (response != null)
            {
                return response.ToString();
            }
            else
            {
                return null;
            }
        }

        internal User_Data Get_User_Data(string user_email)
        {
            User_Data user = new User_Data();
            var requestParams = JsonConvert.SerializeObject(user_email);
            var response = Call_Api_Without_Input("Login/"+user_email);
            user = JsonConvert.DeserializeObject<User_Data>(response.ToString());
            Console.WriteLine(response);
            if (response != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
