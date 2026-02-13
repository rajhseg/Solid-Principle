using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSolid.SOLID
{
    internal interface IPrinter
    {
        void Print(string document);
    }

    internal interface IMail
    {
        void SendMail(string message);
    }

    internal class InterfaceSegregationPrinciple : IPrinter, IMail
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }

        public void SendMail(string message)
        {
            Console.WriteLine($"Sending mail: {message}");
        }
    }

}
