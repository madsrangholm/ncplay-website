//using NCPLAY.BLL.Helpers;
//using NCPLAY.BLL.Interfaces.Riot;
//using NCPLAY.Tests.NUnit.TestCategories;
//using NUnit.Framework;

//namespace NCPLAY.Tests.IntegrationTests.Riot
//{
//    [TestFixture, Integration, Riot]
//    public class RiotIntegration
//    {
//        [Test]
//        public void TestRiotGetAllChampions()
//        {
//            var riotApi = Ioc.Ioc.Container.Resolve<IRiotWebApi>();
//            var response = riotApi.GetAllChampions("eune");
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestRiotGetCurrentGameBySummonerId()
//        {
//            var riotApi = Ioc.Ioc.Container.Resolve<IRiotWebApi>();
//            var response = riotApi.GetCurrentGameBySummonerId("eune", "EUN1", "19361318");
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestRiotGetLeaguesMappedBySummonerId()
//        {
//            var riotApi = Ioc.Ioc.Container.Resolve<IRiotWebApi>();
//            var response = riotApi.GetLeaguesMappedBySummonerId("eune", "19361318");
//            var res = response.Result;

//            var eloCalc = new EloCalculator();

//            var elo = eloCalc.CalculateRiotElo(res["19361318"]);

//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestRiotGetRecentGamesBySummonerId()
//        {
//            var riotApi = Ioc.Ioc.Container.Resolve<IRiotWebApi>();
//            var response = riotApi.GetRecentGamesBySummonerId("eune", "19361318");
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestRiotGetSummonerByName()
//        {
//            var riotApi = Ioc.Ioc.Container.Resolve<IRiotWebApi>();
//            var response = riotApi.GetSummonerByName("eune", "dendi");
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }
//    }
//}