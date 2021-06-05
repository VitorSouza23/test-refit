using System.Threading.Tasks;
using AppConsole.Domain.Console;
using AppConsole.Domain.Options;
using AppConsole.Domain.Users;
using Refit;

namespace AppConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var arg = new Args(args[0]);
            IConsoleService console = new ConsoleService();
            var postApi = RestService.For<IPostApi>("https://jsonplaceholder.typicode.com/");
            int userId = 1, postId = 1;
            switch (arg.Operation)
            {
                case EArgs.GET:
                    console.WriteEnumerable(await postApi.GetAsync(userId));
                    break;
                case EArgs.POST:
                    Post post = new() { Body = "Test", Title = "Test", UserId = userId };
                    console.WriteObject(await postApi.PostAsync(post));
                    break;
                case EArgs.PUT:
                    Post postUpdate = new() { Body = "Test2", Title = "Test2", UserId = userId, Id = postId };
                    console.WriteObject(await postApi.PutAsync(postId, postUpdate));
                    break;
                case EArgs.DELETE:
                    console.WriteObject(await postApi.DeleteAsync(postId));
                    break;
            }
        }
    }
}
