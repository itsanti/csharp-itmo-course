namespace Task1
{
    internal class Building
    {
        public string Address { get; set; }
        public ushort Length { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }

        public Building(string address, ushort length, ushort width, ushort height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public virtual string Print()
        {
            return $"Здание находится по адресу {Address}.\nЕго размеры:\n\tДлина: {Length} м.\n\tШирина: {Width} м.\n\tВысота: {Height} м.";
        }
    }
}
