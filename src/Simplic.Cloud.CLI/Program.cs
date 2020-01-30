using CommandLine;
using Simplic.Cloud.API;
using Simplic.Cloud.API.BusinessPartner;
using Simplic.Cloud.API.DataPort;
using Simplic.Cloud.API.Logistics;
using Simplic.Cloud.BusinessPartner.Api.Model;
using Simplic.Cloud.ResourceScheduler.Api.Model;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Colorful.Console;

namespace Simplic.Cloud.CLI
{
    class Program
    {
        static int Main(string[] args)
        {
            WriteLine(new string('-', System.Console.BufferWidth - 1));
            Write("Simplic Cloud CLI ");
            Write($"{General.Version} ", Color.Green);
            WriteLine($" @ {DateTime.Now.Year} SIMPLIC GmbH");
            PingApi();
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
        /// Ping api
        /// </summary>
        /// <returns></returns>
        private static void PingApi()
        {
            var client = new Client();

            try
            {
                Task.Run(async () =>
                {
                    var result = await client.PingAsync();
                    WriteLine($"Ping api: {result.Version}@{result.DT} of type {result.Type}");
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                WriteLine($"Ping/echo failed: {ex.Message}", Color.Red);
                if (ex.InnerException != null)
                    WriteLine($"Ping/echo failed details: {ex.InnerException.Message}", Color.Red);
            }
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
                    WriteLine($"Login successful. JWT: {user.Token}", Color.Green);
                    WriteLine($" > User: {user.UserName}");

                    var contactApi = new ContactClient(client);

                    for (int i = 0; i < 30; i++)
                    {
                        var contact = await contactApi.CreateAsync(new Contact()
                        {
                            OrganizationId = Guid.Parse("2b94a1c9-b907-4ae6-af2b-507341cb12d9"),
                            Type = ContactTypeEnum.Company,
                            Addresses = new System.Collections.Generic.List<Contact.AddressField>
                            {
                                new Contact.AddressField
                                {
                                    CompanyName = "Sample company_" + i.ToString()
                                }
                            }
                        });
                        Console.WriteLine(" Contact: " + contact.Id.ToString());

                        await Task.Delay(500);

                        var get_contact = await contactApi.GetAsync(contact.Id);
                        Console.WriteLine(" > Contact: " + get_contact.Id);
                        await contactApi.DeleteAsync(get_contact.Id);
                    }
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
                    WriteLine($"Login successful. JWT: {user.Token}", Color.Green);
                    // WriteLine($" > Organization id: {user.OrganizationId}");

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
        /// <param name="readQueueOption">Login object</param>
        private static void DataPortReadQueue(DataPortReadQueue readQueueOption)
        {
            WriteLine($"Login to simplic cloud... {readQueueOption.EMail}");

            var client = new Client();

            try
            {
                Task.Run(async () =>
                {
                    var user = await client.LoginAsync(readQueueOption.EMail, readQueueOption.Password);
                    WriteLine($"Login successful. JWT: {user.Token}", Color.Green);
                    // WriteLine($" > Organization id: {user.OrganizationId}");

                    var dataPortClient = new DataPortClient(client);

                    Console.WriteLine("Begin reading queue");
                    foreach (var queueEntry in await dataPortClient.GetResultQueueItems())
                    {
                        var result = await dataPortClient.GetResult(queueEntry.TransformationQueueId);
                        var fileId = Guid.NewGuid();

                        var directory = readQueueOption.Directory;

                        if (!directory.EndsWith("\\"))
                            directory += "\\";

                        var transformedFile = $"{directory}transformed_{fileId}.xml";
                        var originalFile = $"{directory}original_{fileId}.xml";
                        var failedFile = $"{directory}original_{fileId}_failed.xml";

                        WriteLine($" Process: {queueEntry.TransformationQueueId}...");

                        if (result?.ProcessedContent == null || result?.Status != 2)
                        {
                            WriteLine($"  Failed: {failedFile}", Color.Red);
                            File.WriteAllBytes(failedFile, result.OriginalContent);
                        }
                        else
                        {
                            WriteLine($"  Original: {transformedFile}", Color.Green);
                            File.WriteAllBytes(transformedFile, result.ProcessedContent);

                            WriteLine($"  Transformed: {originalFile}", Color.Green);
                            File.WriteAllBytes(originalFile, result.OriginalContent);
                        }

                        if (readQueueOption.Delete)
                        {
                            WriteLine($"  Remove from queue. {queueEntry.TransformationQueueId}");
                            await dataPortClient.RemoveResultQueueItem(queueEntry.TransformationQueueId);
                        }

                        WriteLine($" Done: {queueEntry.TransformationQueueId}");
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
