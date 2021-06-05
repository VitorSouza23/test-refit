using System;

namespace AppConsole.Domain.Options
{
    public class Args
    {
        private readonly EArgs _eArgs;

        public Args(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));

            _eArgs = value switch
            {
                "get" => EArgs.GET,
                "post" => EArgs.POST,
                "put" => EArgs.PUT,
                "delete" => EArgs.DELETE,
                _ => throw new InvalidOperationException("No valid opration selected. Valid Operations: get, post, put, delete")
            };
        }

        public EArgs Operation => _eArgs;
    }
}