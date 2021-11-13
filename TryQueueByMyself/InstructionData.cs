using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryQueueByMyself
{
    class InstructionData  /*: MarshalByRefObject*/
    {
        public string Instruction;
        public string Data;
        //public InstructionData() : this(null, null)
        //{ }
        public InstructionData(string Instruction, string Data)
        {
            this.Instruction = Instruction;
            this.Data = Data;
        }
        //public override bool Equals(object obj)
        //{
        //    if ((obj == null) || this.GetType().Equals(obj.GetType()))
        //    { return false; }
        //    else
        //    {
        //        InstructionData Info = (InstructionData)obj;
        //        return (Instruction == Info.Instruction) && (Data == Info.Data);
        //    }
        //}
        //public override int GetHashCode()
        //{
        //    return Instruction.GetHashCode() * Data.GetHashCode();
        //}
        public override string ToString()
        {
            return string.Format("Instruction : {0} | Data : {1}", Instruction, Data);
        }
    }
}
