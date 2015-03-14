//using NCPLAY.BLL.Interfaces.Steam;
//using NCPLAY.Tests.NUnit.TestCategories;
//using NUnit.Framework;

//namespace NCPLAY.Tests.IntegrationTests.Steam
//{
//    [TestFixture, Integration, Steam]
//    public class SteamIntegration
//    {
//        [Test]
//        public void TestGetAppList()
//        {
//            var steamApi = Ioc.Ioc.Container.Resolve<ISteamWebApi>();
//            var response = steamApi.GetAppList();
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetPlayerSummaries()
//        {
//            var steamApi = Ioc.Ioc.Container.Resolve<ISteamWebApi>();
//            var response = steamApi.GetPlayerSummaries("76561198015106536");
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetSupportedApiList()
//        {
//            var steamApi = Ioc.Ioc.Container.Resolve<ISteamWebApi>();
//            var response = steamApi.GetSupportedApiList();
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }
//    }
//}