using System;
using System.Globalization;
using System.Text;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace DotNetJsonSerializationBenchmark
{
    public class SingleObjectBenchMark
    {
        private Parameter parameter = Parameter.GetOne(new Random(42));

        [Benchmark(Baseline = true)]
        public string UsingAnymousSerialization()
        {
            return JsonConvert.SerializeObject(
                new
                {
                    parameter.ItemType,
                    parameter.Key,
                    parameter.Name,
                    parameter.Revision,
                    parameter.SequenceId,
                    parameter.Description,
                    parameter.Units,
                    parameter.Prop1,
                    parameter.Prop2,
                    parameter.Prop3,
                    parameter.Prop4,
                    parameter.Prop5,
                    parameter.Prop6,
                    parameter.Prop7,
                    parameter.Prop8,
                    parameter.Prop9,
                    parameter.Prop10,
                    parameter.Prop11,
                    parameter.Prop12,
                    parameter.Prop13,
                    parameter.Prop14,
                    parameter.Prop15,
                    parameter.Prop16,
                    parameter.Prop17,
                    parameter.Prop18,
                    parameter.Prop19,
                    parameter.Prop20,
                    parameter.Prop21,
                    parameter.Prop22,
                    parameter.Prop23,
                    parameter.Prop24,
                    parameter.Prop25,
                    parameter.Prop26,
                    parameter.Prop27,
                    parameter.Prop28,
                    parameter.Prop29,
                    parameter.Prop30,
                    parameter.Prop31,
                    parameter.Prop32,
                    parameter.Prop33,
                    parameter.Prop34,
                    parameter.Prop35,
                    parameter.Prop36,
                    parameter.Prop37,
                    parameter.Prop38,
                    parameter.Prop39,
                    parameter.Prop40,
                    parameter.Prop45,
                    parameter.Prop46,
                    parameter.Prop47,
                    parameter.Prop48,
                    parameter.Prop49,
                    parameter.Prop50
                }
            );
        }

        [Benchmark]
        public string UsingAnymousSerializationWithJsonNet()
        {
            return System.Text.Json.JsonSerializer.Serialize(
                new
                {
                    parameter.ItemType,
                    parameter.Key,
                    parameter.Name,
                    parameter.Revision,
                    parameter.SequenceId,
                    parameter.Description,
                    parameter.Units,
                    parameter.Prop1,
                    parameter.Prop2,
                    parameter.Prop3,
                    parameter.Prop4,
                    parameter.Prop5,
                    parameter.Prop6,
                    parameter.Prop7,
                    parameter.Prop8,
                    parameter.Prop9,
                    parameter.Prop10,
                    parameter.Prop11,
                    parameter.Prop12,
                    parameter.Prop13,
                    parameter.Prop14,
                    parameter.Prop15,
                    parameter.Prop16,
                    parameter.Prop17,
                    parameter.Prop18,
                    parameter.Prop19,
                    parameter.Prop20,
                    parameter.Prop21,
                    parameter.Prop22,
                    parameter.Prop23,
                    parameter.Prop24,
                    parameter.Prop25,
                    parameter.Prop26,
                    parameter.Prop27,
                    parameter.Prop28,
                    parameter.Prop29,
                    parameter.Prop30,
                    parameter.Prop31,
                    parameter.Prop32,
                    parameter.Prop33,
                    parameter.Prop34,
                    parameter.Prop35,
                    parameter.Prop36,
                    parameter.Prop37,
                    parameter.Prop38,
                    parameter.Prop39,
                    parameter.Prop40,
                    parameter.Prop45,
                    parameter.Prop46,
                    parameter.Prop47,
                    parameter.Prop48,
                    parameter.Prop49,
                    parameter.Prop50
                }
            );
        }

        [Benchmark]
        public string UsingStringBuild()
        {
            var stringBuilder = new StringBuilder(1000);

            stringBuilder.Append("{");

            addString(nameof(parameter.ItemType), parameter.ItemType);
            addInt(nameof(parameter.Key), parameter.Key);
            addString(nameof(parameter.Name), parameter.Name);
            addInt(nameof(parameter.Revision), parameter.Revision);
            addInt(nameof(parameter.SequenceId), parameter.SequenceId);
            addString(nameof(parameter.Description), parameter.Description);
            addString(nameof(parameter.Units), parameter.Units);
            addBool(nameof(parameter.Prop1), parameter.Prop1);
            addBool(nameof(parameter.Prop2), parameter.Prop2);
            addBool(nameof(parameter.Prop3), parameter.Prop3);
            addBool(nameof(parameter.Prop4), parameter.Prop4);
            addBool(nameof(parameter.Prop5), parameter.Prop5);
            addString(nameof(parameter.Prop6), parameter.Prop6);
            addBool(nameof(parameter.Prop7), parameter.Prop7);
            addDouble(nameof(parameter.Prop8), parameter.Prop8);
            addString(nameof(parameter.Prop9), parameter.Prop9);
            addString(nameof(parameter.Prop10), parameter.Prop10);
            addBool(nameof(parameter.Prop11), parameter.Prop11);
            addInt(nameof(parameter.Prop12), parameter.Prop12);
            addString(nameof(parameter.Prop13), parameter.Prop13);
            addInt(nameof(parameter.Prop14), parameter.Prop14);
            addString(nameof(parameter.Prop15), parameter.Prop15);
            addString(nameof(parameter.Prop16), parameter.Prop16);
            addString(nameof(parameter.Prop17), parameter.Prop17);
            addString(nameof(parameter.Prop18), parameter.Prop18);
            addString(nameof(parameter.Prop19), parameter.Prop19);
            addString(nameof(parameter.Prop20), parameter.Prop20);
            addString(nameof(parameter.Prop21), parameter.Prop21);
            addString(nameof(parameter.Prop22), parameter.Prop22);
            addBool(nameof(parameter.Prop23), parameter.Prop23);
            addBool(nameof(parameter.Prop24), parameter.Prop24);
            addBool(nameof(parameter.Prop25), parameter.Prop25);
            addBool(nameof(parameter.Prop26), parameter.Prop26);
            addBool(nameof(parameter.Prop27), parameter.Prop27);
            addBool(nameof(parameter.Prop28), parameter.Prop28);
            addBool(nameof(parameter.Prop29), parameter.Prop29);
            addBool(nameof(parameter.Prop30), parameter.Prop30);
            addDouble(nameof(parameter.Prop31), parameter.Prop31);
            addDouble(nameof(parameter.Prop32), parameter.Prop32);
            addBool(nameof(parameter.Prop33), parameter.Prop33);
            addBool(nameof(parameter.Prop34), parameter.Prop34);
            addBool(nameof(parameter.Prop35), parameter.Prop35);
            addString(nameof(parameter.Prop36), parameter.Prop36);
            addBool(nameof(parameter.Prop37), parameter.Prop37);
            addBool(nameof(parameter.Prop38), parameter.Prop38);
            addBool(nameof(parameter.Prop39), parameter.Prop39);
            addBool(nameof(parameter.Prop40), parameter.Prop40);
            addString(nameof(parameter.Prop45), parameter.Prop45);
            addBool(nameof(parameter.Prop46), parameter.Prop46);
            addBool(nameof(parameter.Prop47), parameter.Prop47);
            addBool(nameof(parameter.Prop48), parameter.Prop48);
            addBool(nameof(parameter.Prop49), parameter.Prop49);
            addInt(nameof(parameter.Prop50), parameter.Prop50);

            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            stringBuilder.Append("}");
            return stringBuilder.ToString();

            void addString(string id, string value)
            {
                stringBuilder.Append("\"");
                stringBuilder.Append(id);
                stringBuilder.Append("\":\"");
                stringBuilder.Append(value.Replace("\"", "\\\""));
                stringBuilder.Append("\",");
            }

            void addBool(string id, bool value)
            {
                stringBuilder.Append("\"");
                stringBuilder.Append(id);

                if (value)
                {
                    stringBuilder.Append("\":true,");
                }
                else
                {
                    stringBuilder.Append("\":false,");
                }
            }

            void addDouble(string id, double value)
            {
                stringBuilder.Append("\"");
                stringBuilder.Append(id);
                stringBuilder.Append("\":");
                stringBuilder.Append(value.ToString(CultureInfo.InvariantCulture));
                stringBuilder.Append(",");
            }

            void addInt(string id, int value)
            {
                stringBuilder.Append("\"");
                stringBuilder.Append(id);
                stringBuilder.Append("\":");
                stringBuilder.Append(value.ToString(CultureInfo.InvariantCulture));
                stringBuilder.Append(",");
            }
        }
    }
}
