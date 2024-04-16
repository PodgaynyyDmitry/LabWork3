

namespace DialogWithPCTests
{
    public enum DialogStatus
    {
        NO_SUCH_TOPIC,
        FINISH,
        PHRASES_ENDED
    }
    public class Dialog
    {
        private List<Topic> topics;
        private Computer computer;
        private DialogStatus processingStatus;
        private Status stat;


        public Dialog(List<Topic> topics, Computer computer)
        {
            this.topics = topics;
            this.computer = computer;
           // this.processingStatus = DialogStatus.TOPIC_CHANGE;
            this.stat = Status.TOPIC_CHANGE;
        }

        public DialogStatus StartDialog()
        {
            Console.WriteLine("Привет! Я твой виртуальны друг! На какую тему ты хотел бы поговорить?");
            string res="";
            foreach (Topic topic in topics) { res += topic.GetTopic() + " "; }
            Console.WriteLine(res);
            Console.SetCursorPosition(Console.GetCursorPosition().Left+40, Console.GetCursorPosition().Top);
            string userAnswer = Console.ReadLine();   
            if(computer.ChooseTopic(topics, userAnswer)=="")
            {
               
                Console.WriteLine("К сожалению, я не знаю такую тему!");
                return DialogStatus.NO_SUCH_TOPIC;
            }
            computer.SetCurrentPhrase(computer.GetTopic().GetPhrases().First());
            while(stat!=Status.DIALOG_FINISH)
            {
                string computerAnswer = computer.SayPhrase(userAnswer);
                Console.WriteLine(computerAnswer);
                if (computerAnswer.Contains(" На этом все)"))
                {
                    return DialogStatus.PHRASES_ENDED;
                }
                Console.SetCursorPosition(Console.GetCursorPosition().Left + 40, Console.GetCursorPosition().Top);
                userAnswer = Console.ReadLine();    
                stat=computer.ProcessUserAnswer(userAnswer);
                if(stat==Status.TOPIC_CHANGE)
                {
                    
                    Console.WriteLine("На какую тему ты хотел бы поговорить?");
                    res = "";
                    foreach (Topic topic in topics) { res += topic.GetTopic() + " "; }
                    Console.WriteLine(res);
                    Console.SetCursorPosition(Console.GetCursorPosition().Left + 40, Console.GetCursorPosition().Top);
                    userAnswer = Console.ReadLine();
                    if (computer.ChooseTopic(topics, userAnswer) == "")
                    {
                        
                        Console.WriteLine("К сожалению, я не знаю такую тему!");
                        return DialogStatus.NO_SUCH_TOPIC;
                    }
                    computer.SetCurrentPhrase(computer.GetTopic().GetPhrases().First());
                } 
            }
           return DialogStatus.FINISH;
        }
    }
}