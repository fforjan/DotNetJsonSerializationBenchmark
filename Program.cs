using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;
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

    public class BenchMark
    {
        private Data data = new Data(new Random(42), 30000, 50000, 100);

        [Benchmark(Baseline = true)]
        public string UsingList()
        {
            var total = new List<object>();

            GetParameter(total);
            GetVariables(total);

            return JsonConvert.SerializeObject(new { Type = "VariableList", Value = total});

            void GetParameter(List<object> list)
            {
                foreach(var parameter in data.Parameter)
                {
                    list.Add(new {Type = "Parameter", Name = parameter});
                }
            }

            void GetVariables(List<object> list)
            {
                foreach(var variable in data.Variables)
                {
                    list.Add(new {Type = variable.Contains('[') ? "VariableElement" : "Variable", Name = variable});
                }
            }
        }

        [Benchmark]
        public string UsingPreAllocatedList()
        {
            var total = new List<object>(data.Parameter.Count + data.Variables.Count);

            GetParameter(total);
            GetVariables(total);

            return JsonConvert.SerializeObject(new { Type = "VariableList", Value = total});

            void GetParameter(List<object> list)
            {
                foreach(var parameter in data.Parameter)
                {
                    list.Add(new {Type = "Parameter", Name = parameter});
                }
            }

            void GetVariables(List<object> list)
            {
                foreach(var variable in data.Variables)
                {
                    list.Add(new {Type = variable.Contains('[') ? "VariableElement" : "Variable", Name = variable});
                }
            }
        }

        [Benchmark]
        public string UsingEnum()
        {
            return JsonConvert.SerializeObject(new { Type = "VariableList", Value = GetParameter().Concat(GetVariables())});

            IEnumerable<object> GetParameter()
            {
                foreach(var parameter in data.Parameter)
                {
                    yield return new {Type = "Parameter", Name = parameter};
                }
            }

            IEnumerable<object> GetVariables()
            {
                foreach(var variable in data.Variables)
                {
                    yield return new {Type = variable.Contains('[') ? "VariableElement" : "Variable", Name = variable};
                }
            }
        }

        public class DataInfo
        {
            public string Type { get; set; }
            public string Name { get; set; }
        }

        [Benchmark]
        public string UsingEnumWithClass()
        {
            return JsonConvert.SerializeObject(new { Type = "VariableList", Value = GetParameter().Concat(GetVariables())});

            IEnumerable<DataInfo> GetParameter()
            {
                foreach(var parameter in data.Parameter)
                {
                    yield return new  DataInfo {Type = "Parameter", Name = parameter};
                }
            }

            IEnumerable<DataInfo> GetVariables()
            {
                foreach(var variable in data.Variables)
                {
                    yield return new DataInfo {Type = variable.Contains('[') ? "VariableElement" : "Variable", Name = variable};
                }
            }
        }

         [Benchmark]
        public string UsingEnumWithClassAndJsonNet()
        {
            return System.Text.Json.JsonSerializer.Serialize(new { Type = "VariableList", Value = GetParameter().Concat(GetVariables())});

            IEnumerable<DataInfo> GetParameter()
            {
                foreach(var parameter in data.Parameter)
                {
                    yield return new  DataInfo {Type = "Parameter", Name = parameter};
                }
            }

            IEnumerable<DataInfo> GetVariables()
            {
                foreach(var variable in data.Variables)
                {
                    yield return new DataInfo {Type = variable.Contains('[') ? "VariableElement" : "Variable", Name = variable};
                }
            }
        }


        [Benchmark]
        public string UsingEnumAndStringBuilder()
        {
            var sb = new StringBuilder();
            sb.Append("{\"Type\":\"VariableList\",\"Value\":[");

            bool isNotFirst = false;
            foreach(var parameter in data.Parameter)
            {
                if (isNotFirst)
                {
                    sb.Append(',');
                }
                else
                {
                    isNotFirst = true;
                }

                sb.Append("{\"Type\":\"Parameter\",\"Name\":\"");
                sb.Append(parameter);
                sb.Append("\"}");
            }

            foreach(var variable in data.Variables)
            {
                    
                sb.Append(",{\"Type\":\"");
                sb.Append(variable.Contains('[') ? "VariableElement" : "Variable");
                sb.Append("\",\"Name\":\"");
                sb.Append(variable);
                sb.Append("\"}");
            }

            sb.Append("]}");
            return sb.ToString();
        }

        [Benchmark]
        public string UsingEnumAndPreAllocatedStringBuilder()
        {
            var sb = new StringBuilder((data.Parameter.Count + data.Variables.Count) * 30);
            sb.Append("{\"Type\":\"VariableList\",\"Value\":[");

            bool isNotFirst = false;
            foreach(var parameter in data.Parameter)
            {
                if (isNotFirst)
                {
                    sb.Append(',');
                }
                else
                {
                    isNotFirst = true;
                }

                sb.Append("{\"Type\":\"Parameter\",\"Name\":\"");
                sb.Append(parameter);
                sb.Append("\"}");
            }

            foreach(var variable in data.Variables)
            {
                    
                sb.Append(",{\"Type\":\"");
                sb.Append(variable.Contains('[') ? "VariableElement" : "Variable");
                sb.Append("\",\"Name\":\"");
                sb.Append(variable);
                sb.Append("\"}");
            }

            sb.Append("]}");
            return sb.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
            var benchmark = new BenchMark();

            var dummy = benchmark.UsingEnum();
            var dummy2 = benchmark.UsingEnumAndStringBuilder();

            var same = dummy == dummy2;
            #else
            var summary = BenchmarkRunner.Run<BenchMark>();
            #endif
        }
    }
}
