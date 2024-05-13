namespace Lab_2
{
    public enum MaterialType
    {
        Wood = 1, Metal = 2, Coal = 3, Fuel = 4
    }
}

namespace Lab_2
{
    public class FreightCarriage : Carriage
    {
        public double MaxLoad { get; set; }
        public MaterialType Material { get; set; }
        public double Weight { get; set; }


        public FreightCarriage(string id, double maxLoad, MaterialType material)
            : base(id, "Freight_Carriage")
        {
            Material = material;
            MaxLoad = maxLoad;
        }

    }
}