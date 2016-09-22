using WP.Service.EntityContext;
using WP.Service.Models;

namespace WP.Service
{
    public class TestDb
    {
        static void Main(string[] args)
        {

            using (var ctx = new WpContext())
            {
                var usr = new User() { Name = "Username" };

                ctx.Users.Add(usr);
                ctx.SaveChanges();
            }
        }
    }
}