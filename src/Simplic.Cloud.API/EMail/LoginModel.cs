namespace Simplic.Cloud.API
{
    public class LoginModel
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }

    public class LoginModelResult
    {
        public string JWT { get; set; }
    }
}
