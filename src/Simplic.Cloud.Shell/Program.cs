﻿using CommandLine;
using Simplic.Cloud.API;
using Simplic.Cloud.API.DataPort;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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


            if (args.Length == 0)
            {
                WriteLine("No arguments passed.", Color.Red);
                return 1;
            }

            if (args[0] == "login")
                Parser.Default.ParseArguments<Login>(args)
                       .WithParsed(o =>
                       {
                           Login(o);
                       });

            if (args[0] == "dataport-enqueue-dir")
                Parser.Default.ParseArguments<DataPortEnqueueDir>(args)
                .WithParsed(o =>
                {
                    DataPortEnqueueDir(o);
                });

            if (args[0] == "dataport-read-queue")
                Parser.Default.ParseArguments<DataPortReadQueue>(args)
                .WithParsed(o =>
                {
                    DataPortReadQueue(o);
                });

            return 0;
        }

        /// <summary>
        /// Login into cloud account
        /// </summary>
        /// <param name="login">Login object</param>
        private static void Login(Login login)
        {
            WriteLine($"Login to simplic cloud... {login.EMail}");

            var client = new Client();

            try
            {
                Task.Run(async () =>
                {
                    var user = await client.LoginAsync(login.EMail, login.Password);
                    WriteLine($"Login successful. JWT: {user.JWT}", Color.Green);
                    WriteLine($" > Organization id: {user.OrganizationId}");
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                WriteLine($"Login failed: {ex.Message}", Color.Red);
                if (ex.InnerException != null)
                    WriteLine($"Login failed details: {ex.InnerException.Message}", Color.Red);
            }
        }

        /// <summary>
        /// Login into cloud account
        /// </summary>
        /// <param name="enqueueDirOption">Login object</param>
        private static void DataPortEnqueueDir(DataPortEnqueueDir enqueueDirOption)
        {
            WriteLine($"Login to simplic cloud... {enqueueDirOption.EMail}");

            var client = new Client();

            try
            {
                Task.Run(async () =>
                {
                    var user = await client.LoginAsync(enqueueDirOption.EMail, enqueueDirOption.Password);
                    WriteLine($"Login successful. JWT: {user.JWT}", Color.Green);
                    WriteLine($" > Organization id: {user.OrganizationId}");

                    var dataPortClient = new DataPortClient(client);

                    foreach (var file in Directory.GetFiles(enqueueDirOption.Directory)
                        .OrderBy(x => new FileInfo(x).CreationTime))
                    {
                        await dataPortClient.EnqueueFile(File.ReadAllBytes(file), enqueueDirOption.TransformerName, Path.GetFileName(file));
                        WriteLine($" File enqueued: {file}");

                        if (enqueueDirOption.Delete)
                        {
                            WriteLine(" ... Delete file", Color.Yellow);
                            File.Delete(file);
                        }
                    }

                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                WriteLine($"Enqueue data failed: {ex.Message}", Color.Red);
                if (ex.InnerException != null)
                    WriteLine($"Enqueue data failed details: {ex.InnerException.Message}", Color.Red);
            }
        }

        /// <summary>
        /// Login into cloud account
        /// </summary>
        /// <param name="enqueueDirOption">Login object</param>
        private static void DataPortReadQueue(DataPortReadQueue enqueueDirOption)
        {
            WriteLine($"Login to simplic cloud... {enqueueDirOption.EMail}");

            var client = new Client();

            try
            {
                Task.Run(async () =>
                {
                    var user = await client.LoginAsync(enqueueDirOption.EMail, enqueueDirOption.Password);
                    WriteLine($"Login successful. JWT: {user.JWT}", Color.Green);
                    WriteLine($" > Organization id: {user.OrganizationId}");

                    var dataPortClient = new DataPortClient(client);

                    Console.WriteLine("Begin reading queue");
                    foreach (var queueEntry in await dataPortClient.GetResultQueueItems())
                    {
                        var result = await dataPortClient.GetResult(queueEntry.TransformationQueueId);

                        var original = Encoding.UTF8.GetString(result.OriginalContent);
                        var strResult = Encoding.UTF8.GetString(result.ProcessedContent);
                        Console.WriteLine($"{strResult}");
                        // await dataPortClient.RemoveResultQueueItem(queueEntry.TransformationQueueId);
                    }
                    Console.WriteLine("BegiEnd reading queue");

                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                WriteLine($"Read data failed: {ex.Message}", Color.Red);
                if (ex.InnerException != null)
                    WriteLine($"Read data failed details: {ex.InnerException.Message}", Color.Red);
            }
        }
    }
}
