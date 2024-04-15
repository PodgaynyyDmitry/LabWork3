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
    }
}