using System;

namespace DotNetJsonSerializationBenchmark
{
    public class Parameter
    {
        
        public string ItemType { get; private set; }
        public int Key { get; private set; }
        public string Name { get; private set; }
        public int Revision { get; private set; }
        public int SequenceId { get; private set; }
        public string Description { get; private set; }
        public string Units { get; private set; }
        public bool Prop1 { get; private set; }
        public bool Prop2 { get; private set; }
        public bool Prop3 { get; private set; }
        public bool Prop4 { get; private set; }
        public bool Prop5 { get; private set; }
        public string Prop6 { get; private set; }
        public bool Prop7 { get; private set; }
        public double Prop8 { get; private set; }
        public string Prop9 { get; private set; }
        public string Prop10 { get; private set; }
        public bool Prop11 { get; private set; }
        public int Prop12 { get; private set; }
        public string Prop13 { get; private set; }
        public int Prop14 { get; private set; }
        public string Prop15 { get; private set; }
        public string Prop16 { get; private set; }
        public string Prop17 { get; private set; }
        public string Prop18 { get; private set; }
        public string Prop19 { get; private set; }
        public string Prop20 { get; private set; }
        public string Prop21 { get; private set; }
        public string Prop22 { get; private set; }
        public bool Prop23 { get; private set; }
        public bool Prop24 { get; private set; }
        public bool Prop25 { get; private set; }
        public bool Prop26 { get; private set; }
        public bool Prop27 { get; private set; }
        public bool Prop28 { get; private set; }
        public bool Prop29 { get; private set; }
        public bool Prop30 { get; private set; }
        public double Prop31 { get; private set; }
        public double Prop32 { get; private set; }
        public bool Prop33 { get; private set; }
        public bool Prop34 { get; private set; }
        public bool Prop35 { get; private set; }
        public string Prop36 { get; private set; }
        public bool Prop37 { get; private set; }
        public bool Prop38 { get; private set; }
        public bool Prop39 { get; private set; }
        public bool Prop40 { get; private set; }
        public string Prop45 { get; private set; }
        public bool Prop46 { get; private set; }
        public bool Prop47 { get; private set; }
        public bool Prop48 { get; private set; }
        public bool Prop49 { get; private set; }
        public int Prop50 { get; private set; }

        public static Parameter GetOne(System.Random rnd)
        {
            return
                new Parameter
                {
                    ItemType = "Parameter",
                    Key = rnd.Next(),
                    Name = rnd.NextString(),
                    Revision = rnd.Next(),
                    SequenceId = rnd.Next(),
                    Description = rnd.NextString(),
                    Units = rnd.NextString(),
                    Prop1 = rnd.NextBoolean(),
                    Prop2 = rnd.NextBoolean(),
                    Prop3 = rnd.NextBoolean(),
                    Prop4 = rnd.NextBoolean(),
                    Prop5 = rnd.NextBoolean(),
                    Prop6 = rnd.NextString(),
                    Prop7 = rnd.NextBoolean(),
                    Prop8 = rnd.NextDouble(),
                    Prop9 = rnd.NextString(),
                    Prop10 = rnd.NextString(),
                    Prop11 = rnd.NextBoolean(),
                    Prop12 = rnd.Next(),
                    Prop13 = rnd.NextString(),
                    Prop14 = rnd.Next(),
                    Prop15 = rnd.NextString(),
                    Prop16 = rnd.NextString(),
                    Prop17 = rnd.NextString(),
                    Prop18 = rnd.NextString(),
                    Prop19 = rnd.NextString(),
                    Prop20 = rnd.NextString(),
                    Prop21 = rnd.NextString(),
                    Prop22 = rnd.NextString(),
                    Prop23 = rnd.NextBoolean(),
                    Prop24 = rnd.NextBoolean(),
                    Prop25 = rnd.NextBoolean(),
                    Prop26 = rnd.NextBoolean(),
                    Prop27 = rnd.NextBoolean(),
                    Prop28 = rnd.NextBoolean(),
                    Prop29 = rnd.NextBoolean(),
                    Prop30 = rnd.NextBoolean(),
                    Prop31 = rnd.NextDouble(),
                    Prop32 = rnd.NextDouble(),
                    Prop33 = rnd.NextBoolean(),
                    Prop34 = rnd.NextBoolean(),
                    Prop35 = rnd.NextBoolean(),
                    Prop36 = rnd.NextString(),
                    Prop37 = rnd.NextBoolean(),
                    Prop38 = rnd.NextBoolean(),
                    Prop39 = rnd.NextBoolean(),
                    Prop40 = rnd.NextBoolean(),
                    Prop45 = rnd.NextString(),
                    Prop46 = rnd.NextBoolean(),
                    Prop47 = rnd.NextBoolean(),
                    Prop48 = rnd.NextBoolean(),
                    Prop49 = rnd.NextBoolean(),                    
                    Prop50 = rnd.Next()
                };
        }

    }


    public static class RndExtension
    {

        public static bool NextBoolean(this Random rnd) => rnd.Next() % 2 == 0;

        public static string NextString(this Random rnd) => Guid.NewGuid().ToString();
    }
}
