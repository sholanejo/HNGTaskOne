namespace HNGTaskOne.Models
{
    public class HNGModel
    {
        public string SlackUsername { get; set; }
        public bool Backend { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }

        public HNGModel(string slackUsername, bool backend, int age, string bio)
        {
            SlackUsername = slackUsername;
            Backend = backend;
            Age = age;
            Bio = bio;
        }
    }
}
