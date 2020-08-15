namespace Elitekollektivet.Emulator.GameBoyColor.Processor
{
    public partial class ProcessorComponent
    {
        public byte A { get; set; }

        public byte B { get; set; }

        public byte C { get; set; }

        public byte D { get; set; }

        public byte E { get; set; }

        public byte H { get; set; }

        public byte L { get; set; }

        public byte F { get; set; }

        public ushort SP { get; set; }

        public ushort PC { get; set; }

        public byte I { get; set; }

        public byte R { get; set; }

        public byte M { get; set; }

        public byte T { get => (byte) (M << 2); }

        public byte IME { get; set; }

        private const byte OneCycle = 1;
    }
}