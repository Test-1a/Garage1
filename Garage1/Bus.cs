namespace Garage1
{
    internal class Bus : Vehicle
    {
        public string numberOfSeats;

        public Bus(string regNo, string color, int num, string unique) : base(regNo, color, num)
        {
            numberOfSeats = unique;
        }
    }
}