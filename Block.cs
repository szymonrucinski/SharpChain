using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
namespace Blockchain.Model
{
    public class Block
    {
        public long Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string PrevHash { get; set; }
        public string Hash { get; set; }
        public string Data { get; set; }

        public Block(DateTime timeStamp, string PreviousHash, string data)
        {
            this.Index = 0;
            this.TimeStamp = timeStamp;
            this.PrevHash = PreviousHash;
            this.Data = data;
        }

        public string CalculateHash()
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes($"{TimeStamp}-{PrevHash ?? ""}-{Data}");
            byte[] outputBytes = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(outputBytes);  
        }

    }
}