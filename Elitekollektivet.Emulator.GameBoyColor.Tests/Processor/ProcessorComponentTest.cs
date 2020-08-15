using System;
using System.Collections.Generic;
using System.Linq;
using Elitekollektivet.Emulator.GameBoyColor.Processor;
using Xunit;

namespace Elitekollektivet.Emulator.GameBoyColor.Tests
{
    public class ProcessorComponentTestData
    {
        private static readonly int _testDataLength = 2;

        private static readonly Random _randomizer = new Random();

        public static IEnumerable<object[]> GenerateRandomByte()
        {
            return Enumerable.Range(0, _testDataLength).Select(_ => new object[]
            {
                (byte) _randomizer.Next(0, 0xFE)
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
    }
}