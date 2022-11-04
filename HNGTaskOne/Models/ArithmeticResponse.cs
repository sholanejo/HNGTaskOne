using HNGTaskOne.Enums;

namespace HNGTaskOne.Models
{
    public class ArithmeticResponse
    {
        public ArithmeticResponse()
        {
            slackUsername = "sholanejo";
        }

        public string slackUsername { get; set; }
        public string operation_type { get; set; }
        public int Result { get; set; }
    }
}
