using System;

namespace TryQueueByMyself
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue queue = InputFromUser();
            //Queue newqueue = new Queue();
            //while ()
            //{
            //    InstructionData instructionData = queue.instructionDatas.Dequeue();
            //    do {
            //        newqueue.instructionDatas.Enqueue(instructionData);
            //    } while ()
            //}
        }
        //static bool check(Queue queue)
        //{
        //    Queue newqueue = new Queue();
        //    InstructionData getinstructionFromQueue = queue.instructionDatas.Dequeue();
        //    getinstructionFromQueue = new InstructionData(getinstructionFromQueue.Instruction, null);
        //    newqueue.instructionDatas.Enqueue(getinstructionFromQueue);
        //    InstructionData makeDatanull = queue.ToString
        //    makeDatanull = 
        //    bool a = newqueue.instructionDatas.Contains(getinstructionFromQueue);
        //}
        static string InputInstruction()
        { return Console.ReadLine(); }
        static string InputData()
        { return Console.ReadLine(); }
        static Queue InputFromUser()
        {
            Queue queue = new Queue();//สร้าง queue เปล่าไว้เก็บ InstructionData
            bool IsFinished = false;  
            while (IsFinished != true)//ใช้ลูป While ในการเพิ่มข้อมูล InstructionData เข้าไปใน queue ที่เตรียมไว้ ถ้า IsFinished = true ออกจากลูป
            {
                string Instruction = InputInstruction();
                IsFinished = IsInputFinish(Instruction);// เรียกใช้ Method เพื่อเช็ค ถ้าเป็น true ให้ break ออก เป็น false ก็ให้เพิ่ม Instruction เข้าใน queue
                if (IsFinished == true)
                { break; }
                else
                { queue.instructionDatas.Enqueue(NewinstructionData(Instruction, InputData())); }
            }
            return queue;
        }
        static InstructionData NewinstructionData(string Instruction, string Data)//ตอนเเรกก็สร้าง Instruction รับอักขระจากผู้ใช้ 2 อย่าง คือ ขั้นตอน (instruction) กับ ข้อมูล (data)
        {
            InstructionData instructionData = new InstructionData(Instruction, Data);
            return instructionData;
        }
        static bool IsInputFinish(string Instruction) //check. if User key "?" is mean inputing finished.
        {
            if (Instruction == "?")
            { return true; }
            else
            { return false; }
        }
    }
}
