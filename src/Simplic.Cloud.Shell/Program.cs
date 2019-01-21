using CommandLine;
using Simplic.Cloud.API;
using System;
using System.Drawing;
using System.Threading.Tasks;
using static Colorful.Console;

namespace Simplic.Cloud.Shell
{
    class Program
    {
        static int Main(string[] args)
        {
            WriteLine(new string('-', System.Console.BufferWidth - 1));
            Write("Simplic Cloud Shell ");
            Write($"{General.Version} ", Color.Green);
            WriteLine($" @ {DateTime.Now.Year} SIMPLIC GmbH");
            WriteLine(new string('-', Console.BufferWidth - 1));

            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed(o =>
                   {
                       WriteLine($"Detailed logging: {o.Verbose}", Color.Yellow);
                   });

            if (args.Length == 0)
            {
                WriteLine("No arguments passed.", Color.Red);
                return 1;
            }

            if (args[0] == "login")
                return Parser.Default.ParseArguments<Login>(args)
                  .MapResult(
                    (Login opts) => Login(opts),
                    errs => 1);

            return 0;
        }

        /// <summary>
        /// Login into cloud account
        /// </summary>
        /// <param name="login">Login object</param>
        /// <returns>Application exit code</returns>
        private static int Login(Login login)
        {
            WriteLine($"Login to simplic cloud... {login.EMail}");

            var client = new Client();

            try
            {
                Task.Run(async () =>
                {
                    var result = await client.LoginAsync(login.EMail, login.Password);
                    WriteLine($"Login successful. JWT: {result.JWT}", Color.Green);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                WriteLine($"Login failed: {ex.Message}", Color.Red);
                if(ex.InnerException != null)
                    WriteLine($"Login failed details: {ex.InnerException.Message}", Color.Red);

                return 1;
            }

            return 0;
        }
    }
}
