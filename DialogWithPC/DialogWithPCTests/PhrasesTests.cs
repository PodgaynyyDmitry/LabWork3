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
    }
}