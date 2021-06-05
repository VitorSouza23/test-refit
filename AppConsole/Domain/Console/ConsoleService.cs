using System.Collections.Generic;
using System.Text.Json;
using static System.Console;

namespace AppConsole.Domain.Console
{
    public class ConsoleService : IConsoleService
    {
        public void WriteEnumerable<T>(IEnumerable<T> enumeration)
        {
            foreach (var value in enumeration)
            {
                WriteLine(JsonSerializer.Serialize(value));
            }
        }

        public void WriteObject<T>(T @object)
        {
            WriteLine(JsonSerializer.Serialize(@object));
        }
    }
}