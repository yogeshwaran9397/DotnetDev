﻿using System;
using System.Linq;

namespace CSharpRef.DependencyInjection.VSExample.Stage2
{
    public class ProductRepository : IProductRepository
    {
        void IProductRepository.Save()
        {
            Console.WriteLine("Product inventory updated.");
        }
    }

    public interface IProductRepository
    {
        void Save();
    }
}
