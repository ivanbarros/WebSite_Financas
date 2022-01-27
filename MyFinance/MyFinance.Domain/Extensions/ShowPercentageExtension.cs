using System;

namespace MyFinance.Domain.Extensions
{
    public class ShowPercentageExtension
    {
        public static double GetPercentage(double v_ant, double v_nov) 
        {
            
            double p_lucro = 0.0; // porcentagem de lucro

            while (v_ant + ((p_lucro / 100.0) * v_ant) < v_nov)
            {
                p_lucro = p_lucro + 0.1;
            }

            return Math.Round(p_lucro);
        }
    }
}

