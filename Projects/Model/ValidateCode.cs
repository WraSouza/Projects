namespace Projects.Model
{
    public class ValidateCode
    {
        public ValidateCode(string email, string code)
        {
            Email = email;
            Code = code;
        }

        public string Email { get; private set; }
        public string Code { get; private set; }
    }
}
