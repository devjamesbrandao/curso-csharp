using System;
using System.Collections.Generic;

namespace Generics
{
    public class CalculaService
    {
        public T Maior<T>(List<T> Lista) where T : IComparable
        {

            if(Lista.Count == 0)
            {
                throw new ArgumentException("A lista está vazia");
            }

            T Max = Lista[0];

            for(int i = 1; i < Lista.Count; i++)
            {
                if(Lista[i].CompareTo(Max) > 0)
                {
                    Max = Lista[i];
                }
            }

            return Max;

        }
    }
}