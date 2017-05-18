﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI.Matter
{
    class Program
    {
        static void Main()
        {
            
            // Construct three Uri objects.
            Uri uri1 = new Uri("http://info.softobiz.com/");
            Uri uri2 = new Uri(uri1, "/info.softobiz.com");
            Uri uri3 = new Uri("http://info.softobiz.com/Test/Exists.html?good=true");

            // Write properties.
            //Print(uri1);
            Print(uri2);
            //Print(uri3);
        }

        static void Print(Uri uri)
        {
            // Print properties of Uri instance.
            Console.WriteLine("AbsolutePath = {0}", uri.AbsolutePath);
            Console.WriteLine("AbsoluteUri = {0}", uri.AbsoluteUri);
            Console.WriteLine("Authority = {0}", uri.Authority);
            Console.WriteLine("DnsSafeHost = {0}", uri.DnsSafeHost);
            Console.WriteLine("Fragment = {0}", uri.Fragment);
            Console.WriteLine("Host = {0}", uri.Host);
            Console.WriteLine("HostNameType = {0}", uri.HostNameType);
            Console.WriteLine("IsAbsoluteUri = {0}", uri.IsAbsoluteUri);
            Console.WriteLine("IsDefaultPort = {0}", uri.IsDefaultPort);
            Console.WriteLine("IsFile = {0}", uri.IsFile);
            Console.WriteLine("IsLoopback = {0}", uri.IsLoopback);
            Console.WriteLine("IsUnc = {0}", uri.IsUnc);
            Console.WriteLine("LocalPath = {0}", uri.LocalPath);
            Console.WriteLine("OriginalString = {0}", uri.OriginalString);
            Console.WriteLine("PathAndQuery = {0}", uri.PathAndQuery);
            Console.WriteLine("Port = {0}", uri.Port);
            Console.WriteLine("Query = {0}", uri.Query);
            Console.WriteLine("Scheme = {0}", uri.Scheme);
            Console.WriteLine("Segments = {0}", string.Join(",", uri.Segments));
            Console.WriteLine("UserEscaped = {0}", uri.UserEscaped);
            Console.WriteLine("UserInfo = {0}", uri.UserInfo);
            Console.WriteLine(new string('-', 40));
            Console.Read();
        }
    }

}
