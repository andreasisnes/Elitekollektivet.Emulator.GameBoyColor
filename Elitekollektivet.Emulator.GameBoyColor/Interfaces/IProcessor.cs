namespace Elitekollektivet.Emulator.GameBoyColor.Interfaces
{
    public interface IProcessor
    {
        byte A { get; protected set; }

        byte B { get; protected set; }

        byte C { get; protected set; }

        byte D { get; protected set; }

        byte E { get; protected set; }

        byte H { get; protected set; }

        byte L { get; protected set; }

        byte F { get; protected set; }

        ushort SP { get; protected set; }

        ushort PC { get; protected set; }

        byte I { get; protected set; }

        byte R { get; protected set; }

        byte M { get; protected set; }

        byte T { get; protected set; }

        byte IME { get; protected set; }
    }
}