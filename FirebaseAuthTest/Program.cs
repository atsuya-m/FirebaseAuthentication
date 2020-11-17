using System;
using FirebaseAuthentication;

namespace FirebaseAuthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("AIzaSyBv_9W3xjkp08GgmDmvbxquejy5n9y2iLc");
            var result = client.SignupNewUser.SignUpWithEmailPassword("02milkey15+newemail@gmail.com", "lgc7xtw0").Result;
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(result));
        }
    }
}
