using System;
using System.Collections.Generic;
namespace DotNetJsonSerializationBenchmark
{
    public class Data
    {
        public Data(Random randomizer, int numberOfParameter, int numberOfVariables, int NOC)
        {
            Parameter = new List<string>(numberOfParameter);

            Variables = new List<string>(numberOfVariables);

            for (int i = 0; i < numberOfParameter; i++)
            {
                Parameter.Add(randomizer.Next().ToString());
            }

            for (int i = 0; i < numberOfVariables; i++)
            {
                var last = randomizer.Next().ToString();
                Variables.Add(last);
                if ((i % 5) == 0)
                {
                    for (int c = 0; c < NOC; c++)
                    {
                        Variables.Add(last + "[" + c + "]" );
                    }
                }
            }

        }

        public List<string> Parameter {get;set;}

        public List<string> Variables {get;set;}
    }
}
