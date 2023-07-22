﻿using CSharpRef.DependencyInjection.VSExample;
using System;
using System.Linq;

namespace CSharpRef.DependencyInjection.VSExample.Stage2
{
    public class Notifier : INotifier
    {
        void INotifier.SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt
            Console.WriteLine(string.Format("Receipt sent to customer '{0}' via email.", orderInfo.CustomerName));
        }
    }

    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
