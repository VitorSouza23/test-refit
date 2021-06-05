using System.Collections.Generic;

namespace AppConsole.Domain.Console
{
    public interface IConsoleService
    {
        void WriteEnumerable<T>(IEnumerable<T> enumeration);
        void WriteObject<T>(T @object);
    }
}