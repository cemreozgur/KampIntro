namespace OOP3
{
    internal class SmsLoggerService : IloggerService
    {
        public void Log()
        {
            System.Console.WriteLine("Sms yollandı");
        }
    }
}