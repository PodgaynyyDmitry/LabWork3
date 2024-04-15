

namespace DialogWithPCTests
{
    public class Phrases
    {
        private string positivePhrase;
        private string negativePhrase;

        public Phrases(string v1, string v2)
        {
            this.positivePhrase = v1;
            this.negativePhrase = v2;
        }

        public string GetNegativePhrase()
        {
            return negativePhrase;
        }

        public string GetPositivePhrase()
        {
            return positivePhrase;
        }
    }
}