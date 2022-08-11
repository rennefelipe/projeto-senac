using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    public class passos
    {
        public void andar(int n_passos)
        {
            for (int i = 1; i < n_passos; i++)
            {
                Console.WriteLine("passo n:" + i.ToString());
            }
        }
    }
}
