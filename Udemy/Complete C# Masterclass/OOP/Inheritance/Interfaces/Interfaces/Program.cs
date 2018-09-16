using System;

namespace Interfaces
{

    public interface INotifications
    {
        void showNotification();
        string getDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        // Default Constructor
        public Notification()
        {
            sender = "Admin";
            message = "Wazzaaaaaa";
            date = "";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void showNotification()
        {
            Console.WriteLine("Message: {0}", message);
            Console.WriteLine("- {0}, {1}", sender, date);
        }

        public string getDate()
        {
            return date;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification N1 = new Notification("Grexus", "Who dat?", "16/9/2018");
            Notification N2 = new Notification("JaniceDMenace", "Ja-Nice", "16/9/2018");

            N1.showNotification();
            N2.showNotification();
            Console.Read();
        }
    }
}
