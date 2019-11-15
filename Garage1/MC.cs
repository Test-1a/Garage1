namespace Garage1
{
    internal class MC : Vehicle
    {
        public string cylinderVolume;

        public MC(string regNo, string color, int num, string unique) : base(regNo, color, num)
        {
            
            cylinderVolume = unique;
        }
    }
}