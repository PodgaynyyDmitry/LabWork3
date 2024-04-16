// See https://aka.ms/new-console-template for more information
using DialogWithPCTests;

List<Phrases> phrases = new List<Phrases> { new Phrases("Ты бывал в Париже?",""),
new Phrases("Круто! А в Берлине?","Жаль( А в Берлине?"),
new Phrases("Круто!","Надеюсь, ты еще побываешь)")};

List<Phrases> fishing = new List<Phrases> { new Phrases("Ты бывал рыбалке?",""),
new Phrases("Здорово! Какую самую большую рыбу ты ловил?","А хотел бы попробовать?"),
new Phrases("Круто!","Жаль(")};
List<Topic> topics = new List<Topic> { new Topic("Путешествия",phrases), new Topic("Рыбалка", fishing)};
Computer computer = new Computer();
Dialog dialog = new Dialog(topics,computer);
dialog.StartDialog();
