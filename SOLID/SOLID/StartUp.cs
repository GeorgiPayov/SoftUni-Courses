using SOLID.Appenders;
using SOLID.Layouts;
using SOLID.LogFiles;
using SOLID.ReportLevel;
using System;

namespace SOLID
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ILogger logger = new Logger();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string appendType = input[0];
                string layoutType = input[1];

                IAppender appender = null;
                ILayout layout = null;

                if (layoutType == "SimpleLayout")
                {
                    layout = new SimpleLayout();
                }
                else if (layoutType == "XmlLayout")
                {
                    layout = new XmlLayout();
                }

                if (appendType == "ConsoleAppender")
                {
                    appender = new ConsoleAppender(layout);
                }
                else if (appendType == "FileAppender")
                {
                    var file = new LogFile();
                    appender = new FileAppender(layout, file);
                }

                logger.Appenders.Add(appender);

                if (input.Length == 3)
                {
                    bool isValidLogLevel = Enum.TryParse(input[2], true, out LogLevel logLevel);

                    if (isValidLogLevel)
                    {
                        appender.ReportLevel = logLevel;
                    }
                    
                }

                string[] inputMessages = Console.ReadLine().Split();

                while (inputMessages[0] != "END")
                {




                    inputMessages = Console.ReadLine().Split();
                }
            }
        }
    }
}
