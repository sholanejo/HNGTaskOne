using HNGTaskOne.Models;

namespace HNGTaskOne
{
    public static class HNGService
    {
        public static HNGModel GetService()
        {
            return new HNGModel("T_Major", true, 27, $"My name is Shola Nejo " +
                $"I am backend developer focused on the C# Asp.Net Language " +
                $"One day, I Had a dream I was king, I woke up still King ");
        }
    }
}
