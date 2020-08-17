using System;
using System.Collections.Generic;
using System.Linq;
using Elitekollektivet.Emulator.GameBoyColor.Interfaces;
using Xunit;

namespace Elitekollektivet.Emulator.GameBoyColor.Tests
{
    public class MemoryComponentTestData
    {
        private static readonly int _testDataLength = 10;

        private static readonly Random _randomizer = new Random();

        public static IEnumerable<object[]> GenerateAddrAndByte()
        {
            return Enumerable.Range(0, _testDataLength).Select(_ => new object[]
            {
                (ushort) _randomizer.Next(0, 0xFFFF), (byte) _randomizer.Next(0, 0xFF)
            });
        }

        public static IEnumerable<object[]> GenerateAddrAndTwoBytes()
        {
            return Enumerable.Range(0, _testDataLength).Select(_ => new object[]
            {
                (ushort) _randomizer.Next(0, 0xFFFF), (byte) _randomizer.Next(0, 0xFF), (byte) _randomizer.Next(0, 0xFF)
            });
        }
    }

    public class MemoryComponentTest
    {
        private readonly IMemory _memory;

        public MemoryComponentTest()
        {
            _memory = new MemoryComponent();
        }

        [Theory(DisplayName="ReadByte_Addr_SettedValue")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(MemoryComponentTestData.GenerateAddrAndByte), MemberType= typeof(MemoryComponentTestData))]
        public void ReadByte_Addr_SettedValue(ushort addr, byte expectedByte)
        {
            _memory[addr] = expectedByte;

            var response = _memory.ReadByte(addr);

            Assert.Equal(expectedByte, response);
        }

        [Theory(DisplayName="ReadWord_Addr_SettedValue")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(MemoryComponentTestData.GenerateAddrAndTwoBytes), MemberType= typeof(MemoryComponentTestData))]
        public void ReadWord_Addr_SettedValue(ushort addr, byte firstExpectedByte, byte secondExpectedByte)
        {
            _memory[addr] = firstExpectedByte;
            _memory[(ushort)(addr + 1)] = secondExpectedByte;

            var response = _memory.ReadWord(addr);

            Assert.Equal(firstExpectedByte, (byte) response);
            Assert.Equal(secondExpectedByte, (byte) (response >> 8));
        }

        [Theory(DisplayName="WriteByte_Addr_SettedValue")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(MemoryComponentTestData.GenerateAddrAndByte), MemberType= typeof(MemoryComponentTestData))]
        public void WriteByte_Addr_SettedValue(ushort addr, byte expectedByte)
        {
            _memory.WriteByte(addr, expectedByte);

            Assert.Equal(expectedByte, _memory[addr]);
        }

        [Theory(DisplayName="WriteWord_Addr_SettedValue")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(MemoryComponentTestData.GenerateAddrAndTwoBytes), MemberType= typeof(MemoryComponentTestData))]
        public void WriteWord_Addr_SettedValue(ushort addr, byte firstExpectedByte, byte secondExpectedByte)
        {
            var expected = (ushort)(firstExpectedByte + (secondExpectedByte << 8));
            _memory.WriteWord(addr, expected);

            Assert.Equal(firstExpectedByte, _memory[addr]);
            Assert.Equal(secondExpectedByte, _memory[(ushort) (addr + 1)]);
        }
    }
}
