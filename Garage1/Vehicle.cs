namespace Garage1
{
    internal class Vehicle
    {

        public string RegNr { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public Vehicle(string regNr, string color, int numberOfWheels)
        {
            RegNr = regNr;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
        
    }
}