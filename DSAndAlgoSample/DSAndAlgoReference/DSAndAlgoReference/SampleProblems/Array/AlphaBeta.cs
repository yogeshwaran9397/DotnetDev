﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Array
{
    internal class AlphaBeta
    {
        //If number k appears exactly k times - Alpha
        //If number k appears exactly k times and starts from kth index

        //Input
        //3 3 2 2 5 5 5 5 5 2 2 1
        public void Solution()
        {
            List<int> input = new List<int>() { 3, 3, 2, 2, 5, 5, 5, 5, 5, 2, 2, 1 };
            int Counter = 1, Alpha = 0, Beta = 0;
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    Counter += 1;
                }
                else
                {
                    if (Counter == input[i])
                    {
                        Alpha += 1;
                        if ((Counter - i) == input[i])
                        {
                            Beta += 1;
                        }
                    }
                }
            }
            //1
            //2 2 - counter 2 2 
            //2 2 2 - counter 3 3 
            //2 2 1 - counter 1 3
            if (Counter == input.Last())
            {
                Alpha += 1;
                if ((input.Count - Counter) == input.Last())
                {
                    Beta += 1;
                }
            }
            Console.WriteLine(Alpha - Beta);
        }
    }
}
