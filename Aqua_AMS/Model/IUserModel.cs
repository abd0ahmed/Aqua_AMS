namespace Aqua_AMS.Model
{
   public interface IUserModel
    {
        string FristName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Phone { get; set; }
        int UserID { get; set; }
        string UserName { get; set; }
        int UserRole { get; set; }
    }
}