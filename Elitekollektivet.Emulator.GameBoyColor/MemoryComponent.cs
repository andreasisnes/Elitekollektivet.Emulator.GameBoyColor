using System;
using Elitekollektivet.Emulator.GameBoyColor.Interfaces;

namespace Elitekollektivet.Emulator.GameBoyColor
{
    public class MemoryComponent : IMemory
    {
        private readonly byte[] _memory;

        private const int Kibibyte = 1024;

        private const int MemorySize = 64 * Kibibyte;

        public MemoryComponent()
        {
            _memory = new byte[MemorySize];
        }

        public byte ReadByte(ushort addr)
        {
            return _memory[addr];
        }

        public ushort ReadWord(ushort addr)
        {
            return (ushort)(ReadByte(addr) + (ReadByte(addr + 1) << 8));
        }

        public void WriteByte(ushort addr, byte value)
        {
            _memory[addr] = value;
        }

        public void WriteWord(ushort addr, ushort value)
        {
            WriteByte(addr, (byte)value);
            WriteByte(addr + 1, value >> 8);
        }

        public byte this[ushort index]
        {
            get => _memory[index];
            set => _memory[index] = value;
        }

        public byte ReadByte(object addr) => ReadByte(Convert.ToUInt16(addr));

        public ushort ReadWord(object addr) => ReadWord(Convert.ToUInt16(addr));

        public void WriteByte(object addr, object value) =>  WriteByte(Convert.ToUInt16(addr), Convert.ToByte(value));

        public void WriteWord(object addr, object value) => WriteWord(Convert.ToUInt16(addr), Convert.ToUInt16(value));
    }
}