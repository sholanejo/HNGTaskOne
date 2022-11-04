using HNGTaskOne.Enums;

namespace HNGTaskOne.Models
{
    public class ArithmeticResponse
    {
        public ArithmeticResponse()
        {
            SlackUserName = "sholanejo";
        }

        public string SlackUserName { get; set; }
        public string OperationType { get; set; }
        public int Result { get; set; }
    }
}
