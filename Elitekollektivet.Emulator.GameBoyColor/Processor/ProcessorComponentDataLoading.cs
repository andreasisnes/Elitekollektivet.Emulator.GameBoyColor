namespace Elitekollektivet.Emulator.GameBoyColor.Processor
{
    public partial class ProcessorComponent
    {
        public void LDrrAA() { A=A; M=OneCycle; }

        public void LDrrAB() { A=B; M=OneCycle; }

        public void LDrrAC() { A=C; M=OneCycle; }

        public void LDrrAD() { A=D; M=OneCycle; }

        public void LDrrAE() { A=E; M=OneCycle; }

        public void LDrrAH() { A=H; M=OneCycle; }

        public void LDrrAL() { A=L; M=OneCycle; }


        public void LDrrBA() { B=A; M=OneCycle; }

        public void LDrrBB() { B=B; M=OneCycle; }

        public void LDrrBC() { B=C; M=OneCycle; }

        public void LDrrBD() { B=D; M=OneCycle; }

        public void LDrrBE() { B=E; M=OneCycle; }

        public void LDrrBH() { B=H; M=OneCycle; }

        public void LDrrBL() { B=L; M=OneCycle; }


        public void LDrrCA() { C=A; M=OneCycle; }

        public void LDrrCB() { C=B; M=OneCycle; }

        public void LDrrCC() { C=C; M=OneCycle; }

        public void LDrrCD() { C=D; M=OneCycle; }

        public void LDrrCE() { C=E; M=OneCycle; }

        public void LDrrCH() { C=H; M=OneCycle; }

        public void LDrrCL() { C=L; M=OneCycle; }


        public void LDrrDA() { D=A; M=OneCycle; }

        public void LDrrDB() { D=B; M=OneCycle; }

        public void LDrrDC() { D=C; M=OneCycle; }

        public void LDrrDD() { D=D; M=OneCycle; }

        public void LDrrDE() { D=E; M=OneCycle; }

        public void LDrrDH() { D=H; M=OneCycle; }

        public void LDrrDL() { D=L; M=OneCycle; }


        public void LDrrEA() { E=A; M=OneCycle; }

        public void LDrrEB() { E=B; M=OneCycle; }

        public void LDrrEC() { E=C; M=OneCycle; }

        public void LDrrED() { E=D; M=OneCycle; }

        public void LDrrEE() { E=E; M=OneCycle; }

        public void LDrrEH() { E=H; M=OneCycle; }

        public void LDrrEL() { E=L; M=OneCycle; }


        public void LDrrHA() { H=A; M=OneCycle; }

        public void LDrrHB() { H=B; M=OneCycle; }

        public void LDrrHC() { H=C; M=OneCycle; }

        public void LDrrHD() { H=D; M=OneCycle; }

        public void LDrrHE() { H=E; M=OneCycle; }

        public void LDrrHH() { H=H; M=OneCycle; }

        public void LDrrHL() { H=L; M=OneCycle; }


        public void LDrrLA() { L=A; M=OneCycle; }

        public void LDrrLB() { L=B; M=OneCycle; }

        public void LDrrLC() { L=C; M=OneCycle; }

        public void LDrrLD() { L=D; M=OneCycle; }

        public void LDrrLE() { L=E; M=OneCycle; }

        public void LDrrLH() { L=H; M=OneCycle; }

        public void LDrrLL() { L=L; M=OneCycle; }


        public void LDrmHLA() { A=Memory.ReadByte(HL); M=TwoCycle; }

        public void LDrmHLB() { B=Memory.ReadByte(HL); M=TwoCycle; }

        public void LDrmHLC() { C=Memory.ReadByte(HL); M=TwoCycle; }

        public void LDrmHLD() { D=Memory.ReadByte(HL); M=TwoCycle; }

        public void LDrmHLE() { E=Memory.ReadByte(HL); M=TwoCycle; }

        public void LDrmHLH() { H=Memory.ReadByte(HL); M=TwoCycle; }

        public void LDrmHLL() { L=Memory.ReadByte(HL); M=TwoCycle; }


        public void LDmrHLA() { Memory.WriteByte(HL, A); M=TwoCycle; }

        public void LDmrHLB() { Memory.WriteByte(HL, B); M=TwoCycle; }

        public void LDmrHLC() { Memory.WriteByte(HL, C); M=TwoCycle; }

        public void LDmrHLD() { Memory.WriteByte(HL, D); M=TwoCycle; }

        public void LDmrHLE() { Memory.WriteByte(HL, E); M=TwoCycle; }

        public void LDmrHLH() { Memory.WriteByte(HL, H); M=TwoCycle; }

        public void LDmrHLL() { Memory.WriteByte(HL, L); M=TwoCycle; }


        public void LDrn_A() { A=Memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_B() { B=Memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_C() { C=Memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_D() { D=Memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_E() { E=Memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_H() { H=Memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_L() { L=Memory.ReadByte(PC); PC++; M=TwoCycle; }


        public void LDHLmn() { Memory.WriteByte(HL, Memory.ReadByte(PC)); PC++; M=ThreeCycle; }


        public void LDBCmA() { Memory.WriteByte((B << 8) + C, A); M=TwoCycle; }

        public void LDDEmA() { Memory.WriteByte((D << 8) + E, A); M=TwoCycle; }


        public void LDmmA() { Memory.WriteByte(Memory.ReadWord(PC), A); PC+=2; M=FourCycle; }


        public void LDABCm() { A=Memory.ReadByte((B << 8) + C); M=TwoCycle; }

        public void LDADEm() { A=Memory.ReadByte((D << 8) + E); M=TwoCycle; }


        public void LDAmm() { A=Memory.ReadByte(Memory.ReadWord(PC)); PC+=2; M=FourCycle; }

        public void LDBCnn() { C=Memory.ReadByte(PC); B=Memory.ReadByte(PC+1); PC+=2; M=ThreeCycle; }

        public void LDDEnn() { E=Memory.ReadByte(PC); D=Memory.ReadByte(PC+1); PC+=2; M=ThreeCycle; }

        public void LDHLnn() { L=Memory.ReadByte(PC); H=Memory.ReadByte(PC+1); PC+=2; M=ThreeCycle; }

        public void LDSPnn() { SP=Memory.ReadWord(PC); PC+=2; M=ThreeCycle; }


        public void LDHLmm() { var addr = Memory.ReadWord(PC); PC+=2; L=Memory.ReadByte(addr); H=Memory.ReadByte(addr + 1); M=FiveCycle; }

        public void LDmmHL() { var addr = Memory.ReadWord(PC); PC+=2; Memory.WriteWord(addr, HL); M=FiveCycle; }


        public void LDHLIA() { Memory.WriteByte(HL, A); L++; if(L == 0) H++; M=TwoCycle; }

        public void LDAHLI() { A=Memory.ReadByte(HL); L++; if(L == 0) H++; M=TwoCycle; }


        public void LDHLDA() { Memory.WriteByte(HL, A); L--; if((L ^ 0xff) == 0) H--; M=TwoCycle; }

        public void LDAHLD() { A=Memory.ReadByte(HL); L--; if((L ^ 0xff) == 0) H--; M=TwoCycle; }


        public void LDAIOn() { A=Memory.ReadByte(0xFF00 + Memory.ReadByte(PC)); PC++; M=ThreeCycle; }

        public void LDIOnA() { Memory.WriteByte(0xFF00 + Memory.ReadByte(PC), A); PC++; M=ThreeCycle; }

        public void LDAIOC() { A=Memory.ReadByte(0xFF00 + C); M=TwoCycle; }

        public void LDIOCA() { Memory.WriteByte(0xFF00 + C, A); M=TwoCycle; }


        public void LDHLSPn() { ushort addr=Memory.ReadByte(PC); if (addr > 0x7F) addr=(ushort)-((~addr+1)&+0xff); PC++; addr+=SP; H=(byte)(addr >> 8);L=(byte)addr; M=ThreeCycle; }
    }
}