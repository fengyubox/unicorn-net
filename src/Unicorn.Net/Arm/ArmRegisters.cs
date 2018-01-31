﻿namespace Unicorn.ARM
{
    /// <summary>
    /// Represents the registers of an <see cref="ARMEmulator"/>.
    /// </summary>
    public class ARMRegisters : Registers
    {
        internal ARMRegisters(Emulator emulator) : base(emulator)
        {
            // Space
        }

        // Generated by /scripts/gen_reg_properties.py.

        /// <summary>
        /// Gets or sets the value of APSR register.
        /// </summary>
        public long APSR
        {
            get { return Read(1); }
            set { Write(1, value); }
        }

        /// <summary>
        /// Gets or sets the value of APSR_NZCV register.
        /// </summary>
        public long APSR_NZCV
        {
            get { return Read(2); }
            set { Write(2, value); }
        }

        /// <summary>
        /// Gets or sets the value of CPSR register.
        /// </summary>
        public long CPSR
        {
            get { return Read(3); }
            set { Write(3, value); }
        }

        /// <summary>
        /// Gets or sets the value of FPEXC register.
        /// </summary>
        public long FPEXC
        {
            get { return Read(4); }
            set { Write(4, value); }
        }

        /// <summary>
        /// Gets or sets the value of FPINST register.
        /// </summary>
        public long FPINST
        {
            get { return Read(5); }
            set { Write(5, value); }
        }

        /// <summary>
        /// Gets or sets the value of FPSCR register.
        /// </summary>
        public long FPSCR
        {
            get { return Read(6); }
            set { Write(6, value); }
        }

        /// <summary>
        /// Gets or sets the value of FPSCR_NZCV register.
        /// </summary>
        public long FPSCR_NZCV
        {
            get { return Read(7); }
            set { Write(7, value); }
        }

        /// <summary>
        /// Gets or sets the value of FPSID register.
        /// </summary>
        public long FPSID
        {
            get { return Read(8); }
            set { Write(8, value); }
        }

        /// <summary>
        /// Gets or sets the value of ITSTATE register.
        /// </summary>
        public long ITSTATE
        {
            get { return Read(9); }
            set { Write(9, value); }
        }

        /// <summary>
        /// Gets or sets the value of LR register.
        /// </summary>
        public long LR
        {
            get { return Read(10); }
            set { Write(10, value); }
        }

        /// <summary>
        /// Gets or sets the value of PC register.
        /// </summary>
        public long PC
        {
            get { return Read(11); }
            set { Write(11, value); }
        }

        /// <summary>
        /// Gets or sets the value of SP register.
        /// </summary>
        public long SP
        {
            get { return Read(12); }
            set { Write(12, value); }
        }

        /// <summary>
        /// Gets or sets the value of SPSR register.
        /// </summary>
        public long SPSR
        {
            get { return Read(13); }
            set { Write(13, value); }
        }

        /// <summary>
        /// Gets or sets the value of D0 register.
        /// </summary>
        public long D0
        {
            get { return Read(14); }
            set { Write(14, value); }
        }

        /// <summary>
        /// Gets or sets the value of D1 register.
        /// </summary>
        public long D1
        {
            get { return Read(15); }
            set { Write(15, value); }
        }

        /// <summary>
        /// Gets or sets the value of D2 register.
        /// </summary>
        public long D2
        {
            get { return Read(16); }
            set { Write(16, value); }
        }

        /// <summary>
        /// Gets or sets the value of D3 register.
        /// </summary>
        public long D3
        {
            get { return Read(17); }
            set { Write(17, value); }
        }

        /// <summary>
        /// Gets or sets the value of D4 register.
        /// </summary>
        public long D4
        {
            get { return Read(18); }
            set { Write(18, value); }
        }

        /// <summary>
        /// Gets or sets the value of D5 register.
        /// </summary>
        public long D5
        {
            get { return Read(19); }
            set { Write(19, value); }
        }

        /// <summary>
        /// Gets or sets the value of D6 register.
        /// </summary>
        public long D6
        {
            get { return Read(20); }
            set { Write(20, value); }
        }

        /// <summary>
        /// Gets or sets the value of D7 register.
        /// </summary>
        public long D7
        {
            get { return Read(21); }
            set { Write(21, value); }
        }

        /// <summary>
        /// Gets or sets the value of D8 register.
        /// </summary>
        public long D8
        {
            get { return Read(22); }
            set { Write(22, value); }
        }

        /// <summary>
        /// Gets or sets the value of D9 register.
        /// </summary>
        public long D9
        {
            get { return Read(23); }
            set { Write(23, value); }
        }

        /// <summary>
        /// Gets or sets the value of D10 register.
        /// </summary>
        public long D10
        {
            get { return Read(24); }
            set { Write(24, value); }
        }

        /// <summary>
        /// Gets or sets the value of D11 register.
        /// </summary>
        public long D11
        {
            get { return Read(25); }
            set { Write(25, value); }
        }

        /// <summary>
        /// Gets or sets the value of D12 register.
        /// </summary>
        public long D12
        {
            get { return Read(26); }
            set { Write(26, value); }
        }

        /// <summary>
        /// Gets or sets the value of D13 register.
        /// </summary>
        public long D13
        {
            get { return Read(27); }
            set { Write(27, value); }
        }

        /// <summary>
        /// Gets or sets the value of D14 register.
        /// </summary>
        public long D14
        {
            get { return Read(28); }
            set { Write(28, value); }
        }

        /// <summary>
        /// Gets or sets the value of D15 register.
        /// </summary>
        public long D15
        {
            get { return Read(29); }
            set { Write(29, value); }
        }

        /// <summary>
        /// Gets or sets the value of D16 register.
        /// </summary>
        public long D16
        {
            get { return Read(30); }
            set { Write(30, value); }
        }

        /// <summary>
        /// Gets or sets the value of D17 register.
        /// </summary>
        public long D17
        {
            get { return Read(31); }
            set { Write(31, value); }
        }

        /// <summary>
        /// Gets or sets the value of D18 register.
        /// </summary>
        public long D18
        {
            get { return Read(32); }
            set { Write(32, value); }
        }

        /// <summary>
        /// Gets or sets the value of D19 register.
        /// </summary>
        public long D19
        {
            get { return Read(33); }
            set { Write(33, value); }
        }

        /// <summary>
        /// Gets or sets the value of D20 register.
        /// </summary>
        public long D20
        {
            get { return Read(34); }
            set { Write(34, value); }
        }

        /// <summary>
        /// Gets or sets the value of D21 register.
        /// </summary>
        public long D21
        {
            get { return Read(35); }
            set { Write(35, value); }
        }

        /// <summary>
        /// Gets or sets the value of D22 register.
        /// </summary>
        public long D22
        {
            get { return Read(36); }
            set { Write(36, value); }
        }

        /// <summary>
        /// Gets or sets the value of D23 register.
        /// </summary>
        public long D23
        {
            get { return Read(37); }
            set { Write(37, value); }
        }

        /// <summary>
        /// Gets or sets the value of D24 register.
        /// </summary>
        public long D24
        {
            get { return Read(38); }
            set { Write(38, value); }
        }

        /// <summary>
        /// Gets or sets the value of D25 register.
        /// </summary>
        public long D25
        {
            get { return Read(39); }
            set { Write(39, value); }
        }

        /// <summary>
        /// Gets or sets the value of D26 register.
        /// </summary>
        public long D26
        {
            get { return Read(40); }
            set { Write(40, value); }
        }

        /// <summary>
        /// Gets or sets the value of D27 register.
        /// </summary>
        public long D27
        {
            get { return Read(41); }
            set { Write(41, value); }
        }

        /// <summary>
        /// Gets or sets the value of D28 register.
        /// </summary>
        public long D28
        {
            get { return Read(42); }
            set { Write(42, value); }
        }

        /// <summary>
        /// Gets or sets the value of D29 register.
        /// </summary>
        public long D29
        {
            get { return Read(43); }
            set { Write(43, value); }
        }

        /// <summary>
        /// Gets or sets the value of D30 register.
        /// </summary>
        public long D30
        {
            get { return Read(44); }
            set { Write(44, value); }
        }

        /// <summary>
        /// Gets or sets the value of D31 register.
        /// </summary>
        public long D31
        {
            get { return Read(45); }
            set { Write(45, value); }
        }

        /// <summary>
        /// Gets or sets the value of FPINST2 register.
        /// </summary>
        public long FPINST2
        {
            get { return Read(46); }
            set { Write(46, value); }
        }

        /// <summary>
        /// Gets or sets the value of MVFR0 register.
        /// </summary>
        public long MVFR0
        {
            get { return Read(47); }
            set { Write(47, value); }
        }

        /// <summary>
        /// Gets or sets the value of MVFR1 register.
        /// </summary>
        public long MVFR1
        {
            get { return Read(48); }
            set { Write(48, value); }
        }

        /// <summary>
        /// Gets or sets the value of MVFR2 register.
        /// </summary>
        public long MVFR2
        {
            get { return Read(49); }
            set { Write(49, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q0 register.
        /// </summary>
        public long Q0
        {
            get { return Read(50); }
            set { Write(50, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q1 register.
        /// </summary>
        public long Q1
        {
            get { return Read(51); }
            set { Write(51, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q2 register.
        /// </summary>
        public long Q2
        {
            get { return Read(52); }
            set { Write(52, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q3 register.
        /// </summary>
        public long Q3
        {
            get { return Read(53); }
            set { Write(53, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q4 register.
        /// </summary>
        public long Q4
        {
            get { return Read(54); }
            set { Write(54, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q5 register.
        /// </summary>
        public long Q5
        {
            get { return Read(55); }
            set { Write(55, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q6 register.
        /// </summary>
        public long Q6
        {
            get { return Read(56); }
            set { Write(56, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q7 register.
        /// </summary>
        public long Q7
        {
            get { return Read(57); }
            set { Write(57, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q8 register.
        /// </summary>
        public long Q8
        {
            get { return Read(58); }
            set { Write(58, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q9 register.
        /// </summary>
        public long Q9
        {
            get { return Read(59); }
            set { Write(59, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q10 register.
        /// </summary>
        public long Q10
        {
            get { return Read(60); }
            set { Write(60, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q11 register.
        /// </summary>
        public long Q11
        {
            get { return Read(61); }
            set { Write(61, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q12 register.
        /// </summary>
        public long Q12
        {
            get { return Read(62); }
            set { Write(62, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q13 register.
        /// </summary>
        public long Q13
        {
            get { return Read(63); }
            set { Write(63, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q14 register.
        /// </summary>
        public long Q14
        {
            get { return Read(64); }
            set { Write(64, value); }
        }

        /// <summary>
        /// Gets or sets the value of Q15 register.
        /// </summary>
        public long Q15
        {
            get { return Read(65); }
            set { Write(65, value); }
        }

        /// <summary>
        /// Gets or sets the value of R0 register.
        /// </summary>
        public long R0
        {
            get { return Read(66); }
            set { Write(66, value); }
        }

        /// <summary>
        /// Gets or sets the value of R1 register.
        /// </summary>
        public long R1
        {
            get { return Read(67); }
            set { Write(67, value); }
        }

        /// <summary>
        /// Gets or sets the value of R2 register.
        /// </summary>
        public long R2
        {
            get { return Read(68); }
            set { Write(68, value); }
        }

        /// <summary>
        /// Gets or sets the value of R3 register.
        /// </summary>
        public long R3
        {
            get { return Read(69); }
            set { Write(69, value); }
        }

        /// <summary>
        /// Gets or sets the value of R4 register.
        /// </summary>
        public long R4
        {
            get { return Read(70); }
            set { Write(70, value); }
        }

        /// <summary>
        /// Gets or sets the value of R5 register.
        /// </summary>
        public long R5
        {
            get { return Read(71); }
            set { Write(71, value); }
        }

        /// <summary>
        /// Gets or sets the value of R6 register.
        /// </summary>
        public long R6
        {
            get { return Read(72); }
            set { Write(72, value); }
        }

        /// <summary>
        /// Gets or sets the value of R7 register.
        /// </summary>
        public long R7
        {
            get { return Read(73); }
            set { Write(73, value); }
        }

        /// <summary>
        /// Gets or sets the value of R8 register.
        /// </summary>
        public long R8
        {
            get { return Read(74); }
            set { Write(74, value); }
        }

        /// <summary>
        /// Gets or sets the value of R9 register.
        /// </summary>
        public long R9
        {
            get { return Read(75); }
            set { Write(75, value); }
        }

        /// <summary>
        /// Gets or sets the value of R10 register.
        /// </summary>
        public long R10
        {
            get { return Read(76); }
            set { Write(76, value); }
        }

        /// <summary>
        /// Gets or sets the value of R11 register.
        /// </summary>
        public long R11
        {
            get { return Read(77); }
            set { Write(77, value); }
        }

        /// <summary>
        /// Gets or sets the value of R12 register.
        /// </summary>
        public long R12
        {
            get { return Read(78); }
            set { Write(78, value); }
        }

        /// <summary>
        /// Gets or sets the value of S0 register.
        /// </summary>
        public long S0
        {
            get { return Read(79); }
            set { Write(79, value); }
        }

        /// <summary>
        /// Gets or sets the value of S1 register.
        /// </summary>
        public long S1
        {
            get { return Read(80); }
            set { Write(80, value); }
        }

        /// <summary>
        /// Gets or sets the value of S2 register.
        /// </summary>
        public long S2
        {
            get { return Read(81); }
            set { Write(81, value); }
        }

        /// <summary>
        /// Gets or sets the value of S3 register.
        /// </summary>
        public long S3
        {
            get { return Read(82); }
            set { Write(82, value); }
        }

        /// <summary>
        /// Gets or sets the value of S4 register.
        /// </summary>
        public long S4
        {
            get { return Read(83); }
            set { Write(83, value); }
        }

        /// <summary>
        /// Gets or sets the value of S5 register.
        /// </summary>
        public long S5
        {
            get { return Read(84); }
            set { Write(84, value); }
        }

        /// <summary>
        /// Gets or sets the value of S6 register.
        /// </summary>
        public long S6
        {
            get { return Read(85); }
            set { Write(85, value); }
        }

        /// <summary>
        /// Gets or sets the value of S7 register.
        /// </summary>
        public long S7
        {
            get { return Read(86); }
            set { Write(86, value); }
        }

        /// <summary>
        /// Gets or sets the value of S8 register.
        /// </summary>
        public long S8
        {
            get { return Read(87); }
            set { Write(87, value); }
        }

        /// <summary>
        /// Gets or sets the value of S9 register.
        /// </summary>
        public long S9
        {
            get { return Read(88); }
            set { Write(88, value); }
        }

        /// <summary>
        /// Gets or sets the value of S10 register.
        /// </summary>
        public long S10
        {
            get { return Read(89); }
            set { Write(89, value); }
        }

        /// <summary>
        /// Gets or sets the value of S11 register.
        /// </summary>
        public long S11
        {
            get { return Read(90); }
            set { Write(90, value); }
        }

        /// <summary>
        /// Gets or sets the value of S12 register.
        /// </summary>
        public long S12
        {
            get { return Read(91); }
            set { Write(91, value); }
        }

        /// <summary>
        /// Gets or sets the value of S13 register.
        /// </summary>
        public long S13
        {
            get { return Read(92); }
            set { Write(92, value); }
        }

        /// <summary>
        /// Gets or sets the value of S14 register.
        /// </summary>
        public long S14
        {
            get { return Read(93); }
            set { Write(93, value); }
        }

        /// <summary>
        /// Gets or sets the value of S15 register.
        /// </summary>
        public long S15
        {
            get { return Read(94); }
            set { Write(94, value); }
        }

        /// <summary>
        /// Gets or sets the value of S16 register.
        /// </summary>
        public long S16
        {
            get { return Read(95); }
            set { Write(95, value); }
        }

        /// <summary>
        /// Gets or sets the value of S17 register.
        /// </summary>
        public long S17
        {
            get { return Read(96); }
            set { Write(96, value); }
        }

        /// <summary>
        /// Gets or sets the value of S18 register.
        /// </summary>
        public long S18
        {
            get { return Read(97); }
            set { Write(97, value); }
        }

        /// <summary>
        /// Gets or sets the value of S19 register.
        /// </summary>
        public long S19
        {
            get { return Read(98); }
            set { Write(98, value); }
        }

        /// <summary>
        /// Gets or sets the value of S20 register.
        /// </summary>
        public long S20
        {
            get { return Read(99); }
            set { Write(99, value); }
        }

        /// <summary>
        /// Gets or sets the value of S21 register.
        /// </summary>
        public long S21
        {
            get { return Read(100); }
            set { Write(100, value); }
        }

        /// <summary>
        /// Gets or sets the value of S22 register.
        /// </summary>
        public long S22
        {
            get { return Read(101); }
            set { Write(101, value); }
        }

        /// <summary>
        /// Gets or sets the value of S23 register.
        /// </summary>
        public long S23
        {
            get { return Read(102); }
            set { Write(102, value); }
        }

        /// <summary>
        /// Gets or sets the value of S24 register.
        /// </summary>
        public long S24
        {
            get { return Read(103); }
            set { Write(103, value); }
        }

        /// <summary>
        /// Gets or sets the value of S25 register.
        /// </summary>
        public long S25
        {
            get { return Read(104); }
            set { Write(104, value); }
        }

        /// <summary>
        /// Gets or sets the value of S26 register.
        /// </summary>
        public long S26
        {
            get { return Read(105); }
            set { Write(105, value); }
        }

        /// <summary>
        /// Gets or sets the value of S27 register.
        /// </summary>
        public long S27
        {
            get { return Read(106); }
            set { Write(106, value); }
        }

        /// <summary>
        /// Gets or sets the value of S28 register.
        /// </summary>
        public long S28
        {
            get { return Read(107); }
            set { Write(107, value); }
        }

        /// <summary>
        /// Gets or sets the value of S29 register.
        /// </summary>
        public long S29
        {
            get { return Read(108); }
            set { Write(108, value); }
        }

        /// <summary>
        /// Gets or sets the value of S30 register.
        /// </summary>
        public long S30
        {
            get { return Read(109); }
            set { Write(109, value); }
        }

        /// <summary>
        /// Gets or sets the value of S31 register.
        /// </summary>
        public long S31
        {
            get { return Read(110); }
            set { Write(110, value); }
        }

        /// <summary>
        /// Gets or sets the value of C1_C0_2 register.
        /// </summary>
        public long C1_C0_2
        {
            get { return Read(111); }
            set { Write(111, value); }
        }

        /// <summary>
        /// Gets or sets the value of C13_C0_2 register.
        /// </summary>
        public long C13_C0_2
        {
            get { return Read(112); }
            set { Write(112, value); }
        }

        /// <summary>
        /// Gets or sets the value of C13_C0_3 register.
        /// </summary>
        public long C13_C0_3
        {
            get { return Read(113); }
            set { Write(113, value); }
        }
    }
}
