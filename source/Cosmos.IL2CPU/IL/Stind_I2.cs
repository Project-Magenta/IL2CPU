
using XSharp;
using static XSharp.XSRegisters;

namespace Cosmos.IL2CPU.X86.IL
{
    [Cosmos.IL2CPU.OpCode( ILOpCode.Code.Stind_I2 )]
    public class Stind_I2 : ILOp
    {
        public Stind_I2( XSharp.Assembler.Assembler aAsmblr )
            : base( aAsmblr )
        {
        }

        public override void Execute(_MethodInfo aMethod, ILOpCode aOpCode )
        {
            XS.Pop(EAX);
            XS.Pop(EBX);

            XS.Set(EBX, AX, destinationIsIndirect: true);

            //Stind_I.Assemble(Assembler, 2, DebugEnabled);
        }


        // using System;
        // using System.IO;
        //
        //
        // using CPU = XSharp.Assembler.x86;
        //
        // namespace Cosmos.IL2CPU.IL.X86 {
        // 	[XSharp.Assembler.OpCode(OpCodeEnum.Stind_I2)]
        // 	public class Stind_I2: Op {
        // 		public Stind_I2(ILReader aReader, MethodInformation aMethodInfo)
        // 			: base(aReader, aMethodInfo) {
        // 		}
        // 		public override void DoAssemble() {
        // 			Stind_I.Assemble(Assembler, 2);
        // 		}
        // 	}
        // }

    }
}
