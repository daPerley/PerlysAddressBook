using System;
using System.IO;
using AddressBook.Configures;

namespace AddressBook.LogExceptions
{
    class LogHandler
    {
        public static void WriteToLog(Exception exception)
        {
            try
            {
                using (StreamWriter exceptionLog = new StreamWriter(Constants.pathToLog, true))
                {
                    exceptionLog.WriteLine(DateTime.Now + exception.ToString());
                    exceptionLog.Close();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
