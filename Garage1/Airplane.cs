namespace Garage1
{
    internal class Airplane : Vehicle
    {
        public string numberOfEngines;

        public Airplane(string regNo, string color, int num, string unique) : base(regNo, color, num)
        {
           numberOfEngines = unique;
        }
    }
}