namespace Garage1
{
    internal class Boat : Vehicle
    {
        public string length;

        public Boat(string regNo, string color, int num, string unique) :base(regNo, color, num)
        {
            length = unique;
        }
    }
}