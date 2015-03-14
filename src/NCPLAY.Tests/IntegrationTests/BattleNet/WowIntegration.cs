//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using NCPLAY.BLL.Datatypes.BattleNet.WoW;
//using NCPLAY.BLL.Interfaces.BattleNet;
//using NCPLAY.Tests.NUnit.TestCategories;
//using NUnit.Framework;

//namespace NCPLAY.Tests.IntegrationTests.BattleNet
//{
//    [TestFixture, Integration, BattleNet]
//    public class WowIntegration
//    {
//        private const string Realm = "StormReaver";
//        private const string CharacterName = "Photic";
//	    private const int ItemId = 18803;

//        [Test]
//        public void TestGetAchievement()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetAchievement(2144);
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetAuctionDataStatus()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetAuctionDataStatus(Realm);
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetBattlepetAbilities()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetBattlepetAbilities(640);
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetBattlepetSpecies()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetBattlepetSpecies(258);
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetBattlepetStats()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetBattlepetStats(258);
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetChallengeLeaderboardRealm()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetChallengeLeaderboardRealm(Realm);
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetChallengeLeaderboardRegion()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//            var response = wowApi.GetChallengeLeaderboardRegion();
//            var res = response.Result;
//            Assert.IsNotNull(res);
//        }

//        [Test]
//        public void TestGetCharacterProfile()
//        {
//            var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();

//	        var charFields = Enum.GetValues(typeof (CharacterProfileResponse.CharacterProfileField)).Cast<CharacterProfileResponse.CharacterProfileField>();
//	        Parallel.ForEach(charFields, field =>
//	        {
//		        try
//		        {
//			        var response = wowApi.GetCharacterProfile(Realm, CharacterName,
//				        new List<CharacterProfileResponse.CharacterProfileField>
//				        {
//					        field
//				        });
//			        var res = response.Result;
//			        Assert.IsNotNull(res);
//			        Console.WriteLine(field + " OK!");
//		        }
//		        catch (Exception)
//		        {
//			        Console.WriteLine(field + " FAIL");
//			        Assert.Fail();
//		        }

//	        });
//        }
//		[Test]
//		public void TestGetItem()
//		{
//			var wowApi = Ioc.Ioc.Container.Resolve<IWowApi>();
//			var response = wowApi.GetItem(ItemId);
//			var res = response.Result;
//			Assert.IsNotNull(res);
//		}
//	}
//}