using System;
using System.Text.Json.Nodes;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using KanyeAndRon;

namespace KanyeAndRon

{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 5;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("--------------");
                QuoteGenerator.KanyeQuote();
                Console.WriteLine("--------------");
                QuoteGenerator.RonQuote();
            }
        }
    }
}