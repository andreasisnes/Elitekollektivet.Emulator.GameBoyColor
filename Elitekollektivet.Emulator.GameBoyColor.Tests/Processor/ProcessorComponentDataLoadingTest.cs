using Elitekollektivet.Emulator.GameBoyColor.Processor;
using Xunit;

namespace Elitekollektivet.Emulator.GameBoyColor.Tests
{
    public class ProcessorComponentDataLoadingTestRegisterA
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterA()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrAA_LoadData_AEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAA_LoadData_AEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrAA();
            Assert.Equal(a, _processor.A);
        }

        [Theory(DisplayName="LDrrAB_LoadData_AEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAB_LoadData_AEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrAB();
            Assert.Equal(b, _processor.A);
        }

        [Theory(DisplayName="LDrrAC_LoadData_AEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAC_LoadData_AEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrAC();
            Assert.Equal(c, _processor.A);
        }

        [Theory(DisplayName="LDrrAD_LoadData_AEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAD_LoadData_AEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrAD();
            Assert.Equal(d, _processor.A);
        }

        [Theory(DisplayName="LDrrAE_LoadData_AEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAE_LoadData_AEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrAE();
            Assert.Equal(e, _processor.A);
        }

        [Theory(DisplayName="LDrrAH_LoadData_AEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAH_LoadData_AEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrAH();
            Assert.Equal(h, _processor.A);
        }

        [Theory(DisplayName="LDrrAL_LoadData_AEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrAL_LoadData_AEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrAL();
            Assert.Equal(l, _processor.A);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterB
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterB()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrBA_LoadData_BEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBA_LoadData_BEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrBA();
            Assert.Equal(a, _processor.B);
        }

        [Theory(DisplayName="LDrrBB_LoadData_BEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBB_LoadData_BEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrBB();
            Assert.Equal(b, _processor.B);
        }

        [Theory(DisplayName="LDrrBC_LoadData_BEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBC_LoadData_BEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrBC();
            Assert.Equal(c, _processor.B);
        }

        [Theory(DisplayName="LDrrBD_LoadData_BEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBD_LoadData_BEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrBD();
            Assert.Equal(d, _processor.B);
        }

        [Theory(DisplayName="LDrrBE_LoadData_BEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBE_LoadData_BEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrBE();
            Assert.Equal(e, _processor.B);
        }

        [Theory(DisplayName="LDrrBH_LoadData_BEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBH_LoadData_BEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrBH();
            Assert.Equal(h, _processor.B);
        }

        [Theory(DisplayName="LDrrBL_LoadData_BEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrBL_LoadData_BEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrBL();
            Assert.Equal(l, _processor.B);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterC
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterC()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrCA_LoadData_CEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCA_LoadData_CEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrCA();
            Assert.Equal(a, _processor.C);
        }

        [Theory(DisplayName="LDrrCB_LoadData_CEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCB_LoadData_CEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrCB();
            Assert.Equal(b, _processor.C);
        }

        [Theory(DisplayName="LDrrCC_LoadData_CEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCC_LoadData_CEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrCC();
            Assert.Equal(c, _processor.C);
        }

        [Theory(DisplayName="LDrrCD_LoadData_CEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCD_LoadData_CEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrCD();
            Assert.Equal(d, _processor.C);
        }

        [Theory(DisplayName="LDrrCE_LoadData_CEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCE_LoadData_CEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrCE();
            Assert.Equal(e, _processor.C);
        }

        [Theory(DisplayName="LDrrCH_LoadData_CEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCH_LoadData_CEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrCH();
            Assert.Equal(h, _processor.C);
        }

        [Theory(DisplayName="LDrrCL_LoadData_CEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrCL_LoadData_CEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrCL();
            Assert.Equal(l, _processor.C);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterD
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterD()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrDA_LoadData_DEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDA_LoadData_DEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrDA();
            Assert.Equal(a, _processor.D);
        }

        [Theory(DisplayName="LDrrDB_LoadData_DEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDB_LoadData_DEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrDB();
            Assert.Equal(b, _processor.D);
        }

        [Theory(DisplayName="LDrrDC_LoadData_DEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDC_LoadData_DEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrDC();
            Assert.Equal(c, _processor.D);
        }

        [Theory(DisplayName="LDrrDD_LoadData_DEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDD_LoadData_DEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrDD();
            Assert.Equal(d, _processor.D);
        }

        [Theory(DisplayName="LDrrDE_LoadData_DEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDE_LoadData_DEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrDE();
            Assert.Equal(e, _processor.D);
        }

        [Theory(DisplayName="LDrrDH_LoadData_DEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDH_LoadData_DEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrDH();
            Assert.Equal(h, _processor.D);
        }

        [Theory(DisplayName="LDrrDL_LoadData_DEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrDL_LoadData_DEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrDL();
            Assert.Equal(l, _processor.D);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterE
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterE()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrEA_LoadData_EEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrEA_LoadData_EEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrEA();
            Assert.Equal(a, _processor.E);
        }

        [Theory(DisplayName="LDrrEB_LoadData_EEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrEB_LoadData_EEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrEB();
            Assert.Equal(b, _processor.E);
        }

        [Theory(DisplayName="LDrrEC_LoadData_EEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrEC_LoadData_EEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrEC();
            Assert.Equal(c, _processor.E);
        }

        [Theory(DisplayName="LDrrED_LoadData_EEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrED_LoadData_EEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrED();
            Assert.Equal(d, _processor.E);
        }

        [Theory(DisplayName="LDrrEE_LoadData_EEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrEE_LoadData_EEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrEE();
            Assert.Equal(e, _processor.E);
        }

        [Theory(DisplayName="LDrrEH_LoadData_EEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrEH_LoadData_EEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrEH();
            Assert.Equal(h, _processor.E);
        }

        [Theory(DisplayName="LDrrEL_LoadData_EEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrEL_LoadData_EEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrEL();
            Assert.Equal(l, _processor.E);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterH
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterH()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrHA_LoadData_HEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHA_LoadData_HEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrHA();
            Assert.Equal(a, _processor.H);
        }

        [Theory(DisplayName="LDrrHB_LoadData_HEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHB_LoadData_HEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrHB();
            Assert.Equal(b, _processor.H);
        }

        [Theory(DisplayName="LDrrHC_LoadData_HEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHC_LoadData_HEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrHC();
            Assert.Equal(c, _processor.H);
        }

        [Theory(DisplayName="LDrrHD_LoadData_HEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHD_LoadData_HEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrHD();
            Assert.Equal(d, _processor.H);
        }

        [Theory(DisplayName="LDrrHE_LoadData_HEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHE_LoadData_HEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrHE();
            Assert.Equal(e, _processor.H);
        }

        [Theory(DisplayName="LDrrHH_LoadData_HEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHH_LoadData_HEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrHH();
            Assert.Equal(h, _processor.H);
        }

        [Theory(DisplayName="LDrrHL_LoadData_HEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrHL_LoadData_HEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrHL();
            Assert.Equal(l, _processor.H);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterL
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterL()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrrLA_LoadData_LEqualA")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLA_LoadData_LEqualA(byte a)
        {
            _processor.A = a;
            _processor.LDrrLA();
            Assert.Equal(a, _processor.L);
        }

        [Theory(DisplayName="LDrrLB_LoadData_LEqualB")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLB_LoadData_LEqualB(byte b)
        {
            _processor.B = b;
            _processor.LDrrLB();
            Assert.Equal(b, _processor.L);
        }

        [Theory(DisplayName="LDrrLC_LoadData_LEqualC")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLC_LoadData_LEqualC(byte c)
        {
            _processor.C = c;
            _processor.LDrrLC();
            Assert.Equal(c, _processor.L);
        }

        [Theory(DisplayName="LDrrLD_LoadData_LEqualD")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLD_LoadData_LEqualD(byte d)
        {
            _processor.D = d;
            _processor.LDrrLD();
            Assert.Equal(d, _processor.L);
        }

        [Theory(DisplayName="LDrrLE_LoadData_LEqualE")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLE_LoadData_LEqualE(byte e)
        {
            _processor.E = e;
            _processor.LDrrLE();
            Assert.Equal(e, _processor.L);
        }

        [Theory(DisplayName="LDrrLH_LoadData_LEqualH")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLH_LoadData_LEqualH(byte h)
        {
            _processor.H = h;
            _processor.LDrrLH();
            Assert.Equal(h, _processor.L);
        }

        [Theory(DisplayName="LDrrLL_LoadData_LEqualL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateRandomByte), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrrLL_LoadData_LEqualL(byte l)
        {
            _processor.L = l;
            _processor.LDrrLL();
            Assert.Equal(l, _processor.L);
        }
    }

    public class ProcessorComponentDataLoadingTestMemoryToRegisterHl
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestMemoryToRegisterHl()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDrmHLA_ReadByte_AEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLA_ReadByte_AEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLA();

            Assert.Equal(_processor.A, data);
        }

        [Theory(DisplayName="LDrmHLB_ReadByte_BEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLB_ReadByte_BEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLB();

            Assert.Equal(_processor.B, data);
        }

        [Theory(DisplayName="LDrmHLC_ReadByte_CEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLC_ReadByte_CEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLC();

            Assert.Equal(_processor.C, data);
        }

        [Theory(DisplayName="LDrmHLD_ReadByte_DEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLD_ReadByte_DEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLD();

            Assert.Equal(_processor.D, data);
        }

        [Theory(DisplayName="LDrmHLE_ReadByte_EEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLE_ReadByte_EEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLE();

            Assert.Equal(_processor.E, data);
        }

        [Theory(DisplayName="LDrmHLH_ReadByte_HEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLH_ReadByte_HEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLH();

            Assert.Equal(_processor.H, data);
        }

        [Theory(DisplayName="LDrmHLL_ReadByte_LEqualReadByteOfHl")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDrmHLL_ReadByte_LEqualReadByteOfHl(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.Memory.WriteByte(_processor.HL, data);

            _processor.LDrmHLL();

            Assert.Equal(_processor.L, data);
        }
    }

    public class ProcessorComponentDataLoadingTestRegisterToMemoryHL
    {
        private readonly ProcessorComponent _processor;

        public ProcessorComponentDataLoadingTestRegisterToMemoryHL()
        {
            _processor = new ProcessorComponent();
        }

        [Theory(DisplayName="LDmrHLA_WriteByte_RegisterAToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLA_WriteByte_RegisterAToMemoryHL(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.A = data;

            _processor.LDmrHLA();

            Assert.Equal(data, _processor.Memory.ReadByte(_processor.HL));
        }

        [Theory(DisplayName="LDmrHLB_WriteByte_RegisterBToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLB_WriteByte_RegisterBToMemoryHL(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.B = data;

            _processor.LDmrHLB();

            Assert.Equal(data, _processor.Memory.ReadByte(_processor.HL));
        }

        [Theory(DisplayName="LDmrHLC_WriteByte_RegisterCToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLC_WriteByte_RegisterCToMemoryHL(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.C = data;

            _processor.LDmrHLC();

            Assert.Equal(data, _processor.Memory.ReadByte(_processor.HL));
        }

        [Theory(DisplayName="LDmrHLD_WriteByte_RegisterDToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLD_WriteByte_RegisterDToMemoryHL(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.D = data;

            _processor.LDmrHLD();

            Assert.Equal(data, _processor.Memory.ReadByte(_processor.HL));
        }

        [Theory(DisplayName="LDmrHLE_WriteByte_RegisterEToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateThreeRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLE_WriteByte_RegisterEToMemoryHL(byte H, byte L, byte data)
        {
            _processor.H = H;
            _processor.L = L;
            _processor.E = data;

            _processor.LDmrHLE();

            Assert.Equal(data, _processor.Memory.ReadByte(_processor.HL));
        }

        [Theory(DisplayName="LDmrHLH_WriteByte_RegisterHToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateTwoRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLH_WriteByte_RegisterHToMemoryHL(byte H, byte L)
        {
            _processor.H = H;
            _processor.L = L;

            _processor.LDmrHLH();

            Assert.Equal(H, _processor.Memory.ReadByte(_processor.HL));
        }

        [Theory(DisplayName="LDmrHLL_WriteByte_RegisterLToMemoryHL")]
        [Trait("Category", "Unit")]
        [MemberData(nameof(ProcessorComponentTestData.GenerateTwoRandomBytes), MemberType= typeof(ProcessorComponentTestData))]
        public void LDmrHLL_WriteByte_RegisterLToMemoryHL(byte H, byte L)
        {
            _processor.H = H;
            _processor.L = L;

            _processor.LDmrHLL();

            Assert.Equal(L, _processor.Memory.ReadByte(_processor.HL));
        }
    }
}