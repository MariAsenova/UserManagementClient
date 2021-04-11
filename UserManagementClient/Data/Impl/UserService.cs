using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UserManagementClient.Models;

namespace UserManagementClient.Data.Impl
{
    public class UserService : IUserService
    {
        public async Task<IList<User>> GetAllUsersAsync()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("http://localhost:8080/users/all");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                throw new Exception($@"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

            string result = await response.Content.ReadAsStringAsync();
            IList<User> users = JsonSerializer.Deserialize<IList<User>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            Console.WriteLine(users.Count);
            return users;
        }
    }
}