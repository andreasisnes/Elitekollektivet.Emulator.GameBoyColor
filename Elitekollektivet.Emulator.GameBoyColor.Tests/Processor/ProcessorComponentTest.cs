using System;
using System.Collections.Generic;
using System.Linq;
using Elitekollektivet.Emulator.GameBoyColor.Processor;
using Xunit;

namespace Elitekollektivet.Emulator.GameBoyColor.Tests
{
    public class ProcessorComponentTestData
    {
        private static readonly int _testDataLength = 1;

        private static readonly Random _randomizer = new Random();

        public static IEnumerable<object[]> GenerateRandomByte()
        {
            return Enumerable.Range(0, _testDataLength).Select(_ => new object[]
            {
                (byte) _randomizer.Next(0, 0xFF)
            });
        }

        public static IEnumerable<object[]> GenerateTwoRandomBytes()
        {
            return Enumerable.Range(0, _testDataLength).Select(_ => new object[]
            {
                (byte) _randomizer.Next(0, 0xFF), (byte) _randomizer.Next(0, 0xFF) 
            });
        }

        public static IEnumerable<object[]> GenerateThreeRandomBytes()
        {
            return Enumerable.Range(0, _testDataLength).Select(_ => new object[]
            {
                (byte) _randomizer.Next(0, 0xFF), (byte) _randomizer.Next(0, 0xFF), (byte) _randomizer.Next(0, 0xFF)
            });
        }
    }

    public class ProcessorComponentTest
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentTest()
        {
            _processor = new ProcessorComponent();
        }

        [Fact(DisplayName="Processor_Constructor_RegistersAreSetToZero")]
        [Trait("Category", "Unit")]
        public void Processor_Constructor_RegistersAreSetToZero()
        {
            Assert.Equal(0, _processor.A);
            Assert.Equal(0, _processor.B);
            Assert.Equal(0, _processor.C);
            Assert.Equal(0, _processor.D);
            Assert.Equal(0, _processor.E);
            Assert.Equal(0, _processor.F);
            Assert.Equal(0, _processor.H);
            Assert.Equal(0, _processor.I);
            Assert.Equal(0, _processor.IME);
            Assert.Equal(0, _processor.L);
            Assert.Equal(0, _processor.M);
            Assert.Equal(0, _processor.PC);
            Assert.Equal(0, _processor.R);
            Assert.Equal(0, _processor.SP);
            Assert.Equal(0, _processor.T);
        }

        [Theory(DisplayName="Processor_HL_RegisterConcat")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateTwoRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void Processor_HL_RegisterConcat(byte H, byte L)
        {
            _processor.H = H;
            _processor.L = L;
            Assert.Equal((H << 8) + L, _processor.HL);
        }
    }
}