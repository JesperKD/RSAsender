using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace RSAsender
{
    class Program
    {
        const string publicKeyPath = "c:\\temp\\publickey.xml";
        const string privateKeyPath = "c:\\temp\\privatekey.xml";
        static void Main(string[] args)
        {
            var encrypter = new Encrypter();
            while (true)
            {
                Console.WriteLine("Type string to encrypt: ");
                var dataToEncrypt = Console.ReadLine();

                var encrypted = encrypter.EncryptData(publicKeyPath, Encoding.UTF8.GetBytes(dataToEncrypt));
                Console.WriteLine();
                Console.WriteLine("Encrypted string:");
                Console.WriteLine(Convert.ToBase64String(encrypted));
                Console.WriteLine();
                Console.ReadKey();
            }
        }

    }
}
