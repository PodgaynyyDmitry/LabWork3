namespace DialogWithPCTests
{
    [TestClass]
    public class PhrasesTests
    {
        [TestMethod]
        public void Phrases_ClassCreation_Test()
        {
            Phrases phrases = new Phrases("�������, ��� �� ����� � ������!","����, ��� �� �� ��� � ������(");
            Assert.IsNotNull(phrases);
        }
        [TestMethod]
        public void Phrases_GetPositivePhrase_Test()
        {
            Phrases phrases = new Phrases("�������, ��� �� ����� � ������!", "����, ��� �� �� ��� � ������(");
            string expectedPhrase = "�������, ��� �� ����� � ������!";
            string actualPhrase = phrases.GetPositivePhrase();
            Assert.AreEqual(expectedPhrase, actualPhrase);
        }
        public void Phrases_GetNegativePhrase_Test()
        {
            Phrases phrases = new Phrases("�������, ��� �� ����� � ������!", "����, ��� �� �� ��� � ������(");
            string expectedPhrase = "����, ��� �� �� ��� � ������(";
            string actualPhrase = phrases.GetNegativePhrase();
            Assert.AreEqual(expectedPhrase, actualPhrase);
        }
    }
}