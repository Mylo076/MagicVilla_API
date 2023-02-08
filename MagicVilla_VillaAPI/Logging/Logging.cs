namespace MagicVilla_VillaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if("error" == type.ToLower())
            {
                Console.WriteLine("ERROR - " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
