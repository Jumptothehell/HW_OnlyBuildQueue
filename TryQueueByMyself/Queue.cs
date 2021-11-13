using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryQueueByMyself
{
    class Queue
    {
        public Queue<InstructionData> instructionDatas = new Queue<InstructionData>();
        
        public void ShowInstructionAndDataInQueue()
        {
            foreach (InstructionData instructionData in this.instructionDatas)
            {
                Console.WriteLine(instructionData);
            }
        }
    }
}
