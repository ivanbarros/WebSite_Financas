using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Extensions
{
    public class ShowPercentageExtension
    {
        static void Main(string[] args)
        {
            double v_ant = 300.0; // valor anterior
            double v_nov = 340.0; // valor novo
            double p_lucro = 0.0; // porcentagem de lucro

            while (v_ant + ((p_lucro / 100.0) * v_ant) < v_nov)
            {
                p_lucro = p_lucro + 0.1;
            }

            Console.WriteLine("A porcentagem de lucro foi de: " + p_lucro + "%");
        }
    }
}

