using System;
using System.IO;
using System.Reflection;
using Azure.Storage.Blobs;

namespace CaptureReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void StartProcessing()
        {
            Console.WriteLine($"Processor started using path: {Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}");
            var container = BlobContainerClient.WebBlobContainerName;
        }
    }
}
