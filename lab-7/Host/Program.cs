﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SyndicationServiceLibrary.NotesFeed)))
            {
                host.Open();
                Console.WriteLine("Host status: OK.");
                Console.ReadLine();
            }
        }
    }
}
