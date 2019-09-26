using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiClient.Models;

namespace WebApiClient.Services
{
    public class UserService
    {
        HttpClient client = new HttpClient();
        string uri = "https://localhost:44340/api/users";

        public async Task<IEnumerable<User>> GetUsers()
        {
            var resp = await client.GetAsync(uri);
            var result = resp.Content.ReadAsStringAsync().Result;
            var users = JsonConvert.DeserializeObject<List<User>>(result);
            return users;
        }

        public async Task<User> GetUsersByID(int id)
        {
            var resp = await client.GetAsync(uri + $"/{id}");
            var result = resp.Content.ReadAsStringAsync().Result;
            var user = JsonConvert.DeserializeObject<User>(result);
            return user;
        }

        public async Task<HttpStatusCode> AddUser(User user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                uri, user);
            return response.StatusCode;
        }

        public async Task<HttpStatusCode> DeleteUser(int id)
        {

            HttpResponseMessage response = await client.DeleteAsync(uri+$"/{id}");
            return response.StatusCode;
        }
    }
}
