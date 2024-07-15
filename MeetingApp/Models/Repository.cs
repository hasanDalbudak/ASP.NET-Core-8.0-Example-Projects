namespace MeetingApp.Models
{
    public static class Repository
    {
        public static List<UserInfo> _users = new();

        static Repository()
        {
           _users.Add(new UserInfo(){Id=1,Name="Ali",Email="abc@gmail.com",Phone="1111",WillAttend=true});
           _users.Add(new UserInfo(){Id=2,Name="Hasan",Email="abc2@gmail.com",Phone="1111",WillAttend=true});
           _users.Add(new UserInfo(){Id=3,Name="Ayhan",Email="abc3@gmail.com",Phone="1111",WillAttend=false});
           
        }

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count +1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id ==id);
        }
    }
}