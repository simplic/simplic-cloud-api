using Simplic.Cloud.API;
using Simplic.Cloud.API.HR;
using Simplic.Cloud.API.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Static data
            var organizationId = Guid.Parse("2b94a1c9-b907-4ae6-af2b-507341cb12d9");
            var name = "default";

            var resources = new List<Guid>
            {
                Guid.Parse("dcddc4d7-334d-4652-9864-e9432d486e89"),
                Guid.Parse("e0fb5ea2-715f-4ef1-b805-65f8d498fa16"),
                Guid.Parse("a53a740a-a475-44da-b85f-7003116b5a9c"),
                Guid.Parse("d9596732-0868-40da-8cfe-5498b9726df2"),
                Guid.Parse("28EE6BBD-79FC-42EA-83FF-CA45D80F4114"),
                Guid.Parse("338E4A88-052A-43C5-8AB4-04A645EAED3C"),
                Guid.Parse("506AF853-45DA-4C3A-B436-68382D830678")
            };

            Console.WriteLine("Create test application.");

            var client = new Client();
            // await client.PingAsync();

            var result = await client.LoginAsync("benedikt4@simplic.biz", "123456");

            Console.WriteLine("User login: " + result.UserName);

            var logisticClient = new ResourceSchedulerConfigurationClient(client);
            logisticClient.Url = "http://localhost:49248";

            Guid configurationId = Guid.Empty;

            foreach (var configuration in await logisticClient.GetAllAsync())
            {
                configurationId = configuration.Id;
                Console.WriteLine(configuration.ConfigurationName);
            }

            var profileApi = new ProfileClient(client);
            foreach (var org in (await profileApi.GetProfile()).Organizations)
            {
                Console.WriteLine($"Organization: {org.Id}: {org.Name}");
            }

            var vehicleTelematicApi = new VehicleTelematicClient(client);
            vehicleTelematicApi.Url = "http://localhost:49248";


            var hub = new CLIResourceSchedulerHub(logisticClient);
            await hub.StartAsync();
            await hub.JoinSessionAsync(new JoinSessionModel { ConfigurationId = configurationId });
            await hub.RequestResourceGroupsAsync(new GetResourceGroupsModel { ConfigurationId = configurationId });

            // await hub.RequestResourcesAsync(new GetResourceModel { ConfigurationId = configurationId });
            await hub.RequestDataAsync(new LoadDataModel
            {
                ConfigurationId = configurationId,
                StartDate = new DateTime(2020, 5, 1),
                EndDate = new DateTime(2020, 5, 19)
            });

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Guid tractorUnitResourceGroupId = Guid.Parse("1609765a-4d81-46c4-a23d-530f7fde2da6");

            await Task.Factory.StartNew(async () =>
            {
                double percent = 0d;
                AppointmentBaseModel lastRunningAppointment = null;
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("----");

                    foreach (var appointment in hub.Appointments.OrderBy(x => x.StartDate))
                    {
                        Console.WriteLine(hub.GetAppointmentText(appointment));
                    }

                    var runningAppointment = hub.Appointments.FirstOrDefault(x => x.Status == AppointmentStatus.Running);
                    if (runningAppointment != null)
                    {
                        if (lastRunningAppointment?.Id != runningAppointment?.Id)
                            percent = 0;

                        var startLat = runningAppointment.StartAddress.Latitude;
                        var startLong = runningAppointment.StartAddress.Longitude;

                        var endLat = runningAppointment.EndAddress.Latitude;
                        var endLong = runningAppointment.EndAddress.Longitude;

                        var dLat = endLat - startLat;
                        var dLong = endLong - startLong;

                        var vehiclePosLat = startLat + (dLat * percent);
                        var vehiclePosLong = startLong + (dLong * percent);

                        Console.WriteLine($"Distance: {endLat - vehiclePosLat}/{endLong - vehiclePosLong}");
                        
                        foreach (var resource in runningAppointment.Resources)
                            await vehicleTelematicApi.SetLocationAsync(new SetVehicleLocationModel
                            {
                                ConfigurationId = configurationId,
                                Id = resource,
                                Location = new VehicleLocationModel
                                {
                                    Latitude = vehiclePosLat,
                                    Longitude = vehiclePosLong
                                }
                            });

                        lastRunningAppointment = runningAppointment;
                    }

                    percent += 0.1;

                    if (percent >= 1)
                    {
                        percent = 1;
                    }

                    await Task.Delay(6000);
                }
            });

            // var hrClient = new EmployeeClient(client);
            // await hrClient.CreateAsync(new Employee
            // {
            //     Id = Guid.NewGuid(),
            //     OrganizationId = organizationId,
            //     Matchcode = "HR-Test",
            //     Addresses = new List<Simplic.Cloud.BusinessPartner.Api.Model.Address>
            //     {
            //         new Simplic.Cloud.BusinessPartner.Api.Model.Address
            //         {
            //             Title = "Hr.",
            //             FirstName = "Max",
            //             LastName = "Mustermann",
            //             ZipCode = "31137",
            //             Street = "Str. 1",
            //             Additional01 = "AD01",
            //             City = "HI"
            //         }
            //     },
            //     Employments = new List<Employment>
            //     {
            //         new Employment
            //         {
            //             Number = "T1234",
            //             IsActive = true,
            //             TelematicSystems = new List<TelematicSystem>
            //             {
            //                 new TelematicSystem{ Id = "123123898", Provider = "Spedion", From = new DateTime(2000,1,1) }
            //             }
            //         }
            //     }
            // });


            // Console.WriteLine("Start resource scheduler");
            // 
            // var localClient = new Client(client);
            // localClient.Url = "http://localhost:49248";
            // 
            // var resourceSchedulerClient = new ResourceSchedulerClient(localClient);
            // await resourceSchedulerClient.CreateResourceSchedulerAsync(organizationId, name);
            // 
            // await Task.Delay(5000);
            // 
            // // Create hub
            // var hub = new CLIResourceSchedulerHub(localClient);
            // await hub.StartAsync();
            // 
            // Console.WriteLine("Join resource scheduler session");
            // await hub.JoinSessionAsync(new Simplic.Cloud.ResourceScheduler.Api.Model.JoinSessionRequest
            // {
            //     OName = name,
            //     OId = organizationId
            // });
            // 
            // await hub.RequestResourceGroupsAsync(new GetResourceGroupsRequest
            // {
            //     OName = name,
            //     OId = organizationId
            // });
            // 
            // await hub.RequestResourcesAsync(new GetResourceRequest
            // {
            //     OName = name,
            //     OId = organizationId
            // });


            Console.ReadLine();
        }
    }
}
