namespace Garage1
{
    internal class Car : Vehicle
    {
        public string Fueltype { get; set; }
        public Car(string regNr, string color, int numberOfWheels, string fuel) : base(regNr, color, numberOfWheels)
        {
            Fueltype = fuel;
        }
    }
}