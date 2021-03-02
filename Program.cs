// Hello World! program
using System;
using Newtonsoft.Json;

namespace SharpChain
{
    class Program {         
        static void Main(string[] args)
        {
            Blockchain simonCoin = new Blockchain();  
            simonCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Tadeusz,receiver:Franek,amount:10}"));  
            simonCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Łukasz,receiver:Igor,amount:15}"));  
            simonCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Tomeczek,receiver:Wojtuś,amount:45}"));  
            
            Console.WriteLine(JsonConvert.SerializeObject(simonCoin, Formatting.Indented));          }
    }
}