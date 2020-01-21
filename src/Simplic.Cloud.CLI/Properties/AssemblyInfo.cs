using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Simplic.Cloud.CLI")]
[assembly: AssemblyDescription("Simplic cloud shell, for testing and working with the simplic cloud from the command line interface.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("SIMPLIC GmbH")]
[assembly: AssemblyProduct("Simplic cloud shell for easy api access")]
[assembly: AssemblyCopyright("Copyright © SIMPLIC GmbH 2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("381fe878-0c7c-476d-8133-690aea5b73d2")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(Simplic.Cloud.CLI.General.Version)]
[assembly: AssemblyFileVersion(Simplic.Cloud.CLI.General.Version)]

namespace Simplic.Cloud.CLI
{
    public static class General
    {
        public const string Version = "1.1.19.124";
    }
}