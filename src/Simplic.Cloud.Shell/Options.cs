using CommandLine;

namespace Simplic.Cloud.Shell
{
    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }

    [Verb("login", HelpText = "Login into the webapi. Returns a jwt and save it in the user profile.")]
    public class Login
    {
        [Value(0, Hidden = true, MetaName = "Method",
            HelpText = "Method.",
            Required = true)]
        public string Method { get; set; }

        [Value(1, MetaName = "E-Mail address",
            HelpText = "User e-mail address.",
            Required = true)]
        public string EMail { get; set; }

        [Value(2, MetaName = "Password",
            HelpText = "User password.",
            Required = true)]
        public string Password { get; set; }
    }
}
