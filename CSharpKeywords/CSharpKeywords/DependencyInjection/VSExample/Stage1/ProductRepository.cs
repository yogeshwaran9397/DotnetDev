﻿using System;
using System.Linq;

namespace CSharpRef.DependencyInjection.VSExample.Stage1
{
    public class ProductRepository
    {
        public void Save()
        {
            Console.WriteLine("Product inventory updated.");
        }
    }
}
