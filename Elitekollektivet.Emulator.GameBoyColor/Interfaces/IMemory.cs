namespace Elitekollektivet.Emulator.GameBoyColor.Interfaces
{
    public interface IMemory
    {
        byte ReadByte(ushort addr);

        byte ReadByte(object addr);

        ushort ReadWord(ushort addr);

        ushort ReadWord(object addr);

        void WriteByte(ushort addr, byte value);

        void WriteByte(object addr, object value);

        void WriteWord(ushort addr, ushort value);

        void WriteWord(object addr, object value);

        byte this[ushort index] { get; set; }
    }
}