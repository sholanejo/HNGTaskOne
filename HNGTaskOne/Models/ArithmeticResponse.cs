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
        public string operation_type { get; set; }
        public int Result { get; set; }
    }
}
