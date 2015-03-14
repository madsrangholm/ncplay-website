using NCPLAY.BLL.Interfaces.BattleNet;
using Xunit;
namespace NCPLAY.Tests.IntegrationTests.BattleNet
{
   // [TestFixture, Integration, BattleNet]
    public class Sc2Integration
    {
        private const int Id = 677952;
        private const string Name = "TypingMonkey";

        private const int Id2 = 5598407;
        private const string Name2 = "JJohansen";

        private const int LadderId = 168962;

        [Fact]
        public void TestGetProfile()
        {
			Assert.Equal(2+2, 5);

            //var sc2Api = Ioc.Ioc.Container.Resolve<ISc2Api>();
            //var response = sc2Api.GetProfile(Id, Name);
            //var res = response.Result;
            //Assert.IsNotNull(res);
        }
        //[Test]
        //public void TestGetProfileLadders()
        //{
        //    var sc2Api = Ioc.Ioc.Container.Resolve<ISc2Api>();
        //    var response = sc2Api.GetProfileLadders(Id, Name);
        //    var res = response.Result;
        //    Assert.IsNotNull(res);
        //}
        //[Test]
        //public void TestGetProfileMatchHistory()
        //{
        //    var sc2Api = Ioc.Ioc.Container.Resolve<ISc2Api>();
        //    var response = sc2Api.GetProfileMatchHistory(Id2, Name2);
        //    var res = response.Result;
        //    Assert.IsNotNull(res);
        //}
        //[Test]
        //public void TestGetLadder()
        //{
        //    var sc2Api = Ioc.Ioc.Container.Resolve<ISc2Api>();
        //    var response = sc2Api.GetLadder(LadderId);
        //    var res = response.Result;
        //    Assert.IsNotNull(res);
        //}
        //[Test]
        //public void TestGetAchievements()
        //{
        //    var sc2Api = Ioc.Ioc.Container.Resolve<ISc2Api>();
        //    var response = sc2Api.GetAchievements();
        //    var res = response.Result;
        //    Assert.IsNotNull(res);
        //}
        //[Test]
        //public void TestGetRewards()
        //{
        //    var sc2Api = Ioc.Ioc.Container.Resolve<ISc2Api>();
        //    var response = sc2Api.GetRewards();
        //    var res = response.Result;
        //    Assert.IsNotNull(res);
        //}
    }
}
