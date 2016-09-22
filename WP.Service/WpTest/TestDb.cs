using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP.Service.EntityContext;
using WP.Service.Models;

namespace WP.Service
{
    [TestClass]
    public class TestDb
    {
        [TestMethod]
        public void DnConnectionTest()
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