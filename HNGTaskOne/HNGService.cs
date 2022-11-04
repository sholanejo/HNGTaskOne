using HNGTaskOne.Enums;
using HNGTaskOne.Models;

namespace HNGTaskOne
{
    public static class HNGService
    {
        static List<string> opttype = new List<string> { "addition", "multiplication", "subtraction" };

        public static HNGModel GetService()
        {
            return new HNGModel("sholanejo", true, 15, $"My name is Shola Nejo " +
                $"I am backend developer focused on the C# Asp.Net Language " +
                $"One day, I Had a dream I was king, I woke up still King ");
        }

        public static ArithmeticResponse PostService(ArithmeticDTO arithmeticDTO)
        {
            var arithemeticResponse = new ArithmeticResponse();

            int result = 0;
            var operationType = arithmeticDTO.operation_type.ToLower();

            if (!opttype.Contains(operationType))
            {
                arithemeticResponse.Result = result;
                arithemeticResponse.operation_type = "Invalid operation type! Operation can only be addition, multiplication, or subtraction.";

                return arithemeticResponse;
            }


            if (operationType == OperationType.addition.ToString())
            {
                result = arithmeticDTO.X + arithmeticDTO.Y;
            }

            if (operationType == OperationType.subtraction.ToString())
            {
                result = arithmeticDTO.X - arithmeticDTO.Y;
            }

            if (operationType == OperationType.multiplication.ToString())
            {
                result = arithmeticDTO.X * arithmeticDTO.Y;
            }

            arithemeticResponse.Result = result;
            arithemeticResponse.operation_type = arithmeticDTO.operation_type;

            return arithemeticResponse;
        }
    }
}
