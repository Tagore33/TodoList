using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TodoList.Repsotiory;
namespace TodoList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilderTodoList().Build();
            
            
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<TodoListForm>());

            }

            static IHostBuilder CreateHostBuilderTodoList()
            {
                return Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) => {
                        services.AddTransient<TodoListForm>();
                        services.AddSingleton<ITodoTasksRepository,InMemTodoTasksRepository>();
                    });
        
            }
    }
}