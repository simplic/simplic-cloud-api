using CommandLine;

namespace Simplic.Cloud.CLI
{
    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        [Option('d', "delete", Required = false, HelpText = "If set, the source file will be deleted.")]
        public bool Delete { get; set; }
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

    [Verb("dataport-enqueue-dir", HelpText = "Login into the webapi. Returns a jwt and save it in the user profile.")]
    public class DataPortEnqueueDir
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
        
        [Value(3, MetaName = "Transformer name",
            HelpText = "Transformer name",
            Required = true)]
        public string TransformerName { get; set; }

        [Value(4, MetaName = "Directory",
            HelpText = "Directory path.",
            Required = true)]
        public string Directory { get; set; }

        [Option('d', "delete", Required = false, HelpText = "If set, the source file will be deleted.")]
        public bool Delete { get; set; }
    }

    [Verb("dataport-read-queue", HelpText = "Login into the webapi. Returns a jwt and save it in the user profile.")]
    public class DataPortReadQueue
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

        [Value(3, MetaName = "Directory",
            HelpText = "Directory path.",
            Required = true)]
        public string Directory { get; set; }

        [Option('d', "delete", Required = false, HelpText = "If set, the file will be set as processed")]
        public bool Delete { get; set; }
    }
}
