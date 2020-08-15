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


        public void LDrmHLA() { A=_memory.ReadByte((H << 8) + L); M=TwoCycle; }

        public void LDrmHLB() { B=_memory.ReadByte((H << 8) + L); M=TwoCycle; }

        public void LDrmHLC() { C=_memory.ReadByte((H << 8) + L); M=TwoCycle; }

        public void LDrmHLD() { D=_memory.ReadByte((H << 8) + L); M=TwoCycle; }

        public void LDrmHLE() { E=_memory.ReadByte((H << 8) + L); M=TwoCycle; }

        public void LDrmHLH() { H=_memory.ReadByte((H << 8) + L); M=TwoCycle; }

        public void LDrmHLL() { L=_memory.ReadByte((H << 8) + L); M=TwoCycle; }


        public void LDmrHLA() { _memory.WriteByte((H << 8) + L, A); M=TwoCycle; }

        public void LDmrHLB() { _memory.WriteByte((H << 8) + L, B); M=TwoCycle; }

        public void LDmrHLC() { _memory.WriteByte((H << 8) + L, C); M=TwoCycle; }

        public void LDmrHLD() { _memory.WriteByte((H << 8) + L, D); M=TwoCycle; }

        public void LDmrHLE() { _memory.WriteByte((H << 8) + L, E); M=TwoCycle; }

        public void LDmrHLH() { _memory.WriteByte((H << 8) + L, H); M=TwoCycle; }

        public void LDmrHLL() { _memory.WriteByte((H << 8) + L, L); M=TwoCycle; }


        public void LDrn_A() { A=_memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_B() { B=_memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_C() { C=_memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_D() { D=_memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_E() { E=_memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_H() { H=_memory.ReadByte(PC); PC++; M=TwoCycle; }

        public void LDrn_L() { L=_memory.ReadByte(PC); PC++; M=TwoCycle; }


        public void LDHLmn() { _memory.WriteByte((H << 8) + L, _memory.ReadByte(PC)); PC++; M=ThreeCycle; }


        public void LDBCmA() { _memory.WriteByte((B << 8) + C, A); M=TwoCycle; }

        public void LDDEmA() { _memory.WriteByte((D << 8) + E, A); M=TwoCycle; }


        public void LDmmA() { _memory.WriteByte(_memory.ReadWord(PC), A); PC+=2; M=FourCycle; }


        public void LDABCm() { A=_memory.ReadByte((B << 8) + C); M=TwoCycle; }

        public void LDADEm() { A=_memory.ReadByte((D << 8) + E); M=TwoCycle; }


        public void LDAmm() { A=_memory.ReadByte(_memory.ReadWord(PC)); PC+=2; M=FourCycle; }

        public void LDBCnn() { C=_memory.ReadByte(PC); B=_memory.ReadByte(PC+1); PC+=2; M=ThreeCycle; }

        public void LDDEnn() { E=_memory.ReadByte(PC); D=_memory.ReadByte(PC+1); PC+=2; M=ThreeCycle; }

        public void LDHLnn() { L=_memory.ReadByte(PC); H=_memory.ReadByte(PC+1); PC+=2; M=ThreeCycle; }

        public void LDSPnn() { SP=_memory.ReadWord(PC); PC+=2; M=ThreeCycle; }


        public void LDHLmm() { var addr = _memory.ReadWord(PC); PC+=2; L=_memory.ReadByte(addr); H=_memory.ReadByte(addr + 1); M=FiveCycle; }

        public void LDmmHL() { var addr = _memory.ReadWord(PC); PC+=2; _memory.WriteWord(addr, (H << 8) + L); M=FiveCycle; }


        public void LDHLIA() { _memory.WriteByte((H << 8) + L, A); L++; if(L == 0) H++; M=TwoCycle; }

        public void LDAHLI() { A=_memory.ReadByte((H << 8) + L); L++; if(L == 0) H++; M=TwoCycle; }


        public void LDHLDA() { _memory.WriteByte((H << 8) + L, A); L--; if((L ^ 0xff) == 0) H--; M=TwoCycle; }

        public void LDAHLD() { A=_memory.ReadByte((H << 8) + L); L--; if((L ^ 0xff) == 0) H--; M=TwoCycle; }


        public void LDAIOn() { A=_memory.ReadByte(0xFF00 + _memory.ReadByte(PC)); PC++; M=ThreeCycle; }

        public void LDIOnA() { _memory.WriteByte(0xFF00 + _memory.ReadByte(PC), A); PC++; M=ThreeCycle; }

        public void LDAIOC() { A=_memory.ReadByte(0xFF00 + C); M=TwoCycle; }

        public void LDIOCA() { _memory.WriteByte(0xFF00 + C, A); M=TwoCycle; }


        public void LDHLSPn() { ushort addr=_memory.ReadByte(PC); if (addr > 0x7F) addr=(ushort)-((~addr+1)&+0xff); PC++; addr+=SP; H=(byte)(addr >> 8);L=(byte)addr; M=ThreeCycle; }
    }
}