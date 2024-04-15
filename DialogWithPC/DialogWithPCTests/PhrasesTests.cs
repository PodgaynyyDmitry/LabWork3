namespace DialogWithPCTests
{
    [TestClass]
    public class PhrasesTests
    {
        [TestMethod]
        public void Phrases_ClassCreation_Test()
        {
            Phrases phrases = new Phrases("«дорово, что ты бывал в ѕариже!","∆аль, что ты не был в ѕариже(");
            Assert.IsNotNull(phrases);
        }
        [TestMethod]
        public void Phrases_GetPositivePhrase_Test()
        {
            Phrases phrases = new Phrases("«дорово, что ты бывал в ѕариже!", "∆аль, что ты не был в ѕариже(");
            string expectedPhrase = "«дорово, что ты бывал в ѕариже!";
            string actualPhrase = phrases.GetPositivePhrase();
            Assert.AreEqual(expectedPhrase, actualPhrase);
        }
        public void Phrases_GetNegativePhrase_Test()
        {
            Phrases phrases = new Phrases("«дорово, что ты бывал в ѕариже!", "∆аль, что ты не был в ѕариже(");
            string expectedPhrase = "∆аль, что ты не был в ѕариже(";
            string actualPhrase = phrases.GetNegativePhrase();
            Assert.AreEqual(expectedPhrase, actualPhrase);
        }
    }
}