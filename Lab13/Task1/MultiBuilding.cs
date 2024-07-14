namespace Task1
{
    internal sealed class MultiBuilding : Building
    {
        public byte Floors { get; set; }

        public MultiBuilding(string address, ushort length, ushort width, ushort height, byte floors)
            :base(address, length, width, height)
        {
            Floors = floors;
        }

        public override string Print()
        {
            return base.Print() + $"\nЕго этажность: {Floors}";
        }
    }

}
