namespace FM.SHDML.Core.Models.Users
{
    public class UserModel : IUserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}