﻿using Unicorn.Internal;

namespace Unicorn.x86
{
    /// <summary>
    /// Represents an x86 architecture <see cref="Emulator"/>.
    /// </summary>
    public class x86Emulator : Emulator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="x86Emulator"/> class with the specified
        /// <see cref="x86Mode"/> to use.
        /// </summary>
        /// <param name="mode">Mode to use.</param>
        public x86Emulator(x86Mode mode) : base(UnicornArch.UC_ARCH_X86, (UnicornMode)mode)
        {
            _registers = new x86Registers(this);
        }

        private readonly x86Registers _registers;

        /// <summary>
        /// Gets the <see cref="x86Registers"/> of the <see cref="x86Emulator"/> instance.
        /// </summary>
        public x86Registers Registers
        {
            get
            {
                CheckDisposed();

                return _registers;
            }
        }
    }
}