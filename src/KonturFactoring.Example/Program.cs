﻿using KonturFactoring.Api;
using System;

namespace KonturFactoring.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new KonturFactoringHttpClient(null);

            (var auth, var error) = client.AuthAsync("testlogin", "testpassword").Result;

            (var docs, var docError) = client.GetDocumentsAsync(auth.AccessToken, DateTime.Now.AddDays(-5), 1337, 0, 5).Result;

        }
    }
}
