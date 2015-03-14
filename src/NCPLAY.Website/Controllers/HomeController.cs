using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NCPLAY.BLL.Datatypes.BattleNet.Starcraft2;
using NCPLAY.BLL.Interfaces.BattleNet;

namespace NCPLAY.Website.Controllers
{
	public class HomeController : Controller
	{
		private readonly ISc2Api _sc2Api;

		public HomeController(ISc2Api sc2Api)
		{
			_sc2Api = sc2Api;
		}

		public IActionResult Index()
		{
			var watch = new Stopwatch();
			watch.Start();


			//var jonasProfile = _sc2Api.GetProfileMatchHistory(5598407, "JJohansen").Result;

			var ladder = _sc2Api.GetLadder(168962).Result;
			watch.Stop();
			//var wins = jonasProfile.Matches.Count(x => x.Decision == Sc2MatchResult.Win);
			//var lost = jonasProfile.Matches.Count(x => x.Decision != Sc2MatchResult.Win);
			//ViewBag.Title = "Jonas winrate = " + (wins*100/(double) (lost+wins)).ToString("F")+ " %";
			ViewBag.Title = ladder.LadderMembers.Count;
			ViewBag.ServiceCallTime = watch.ElapsedMilliseconds;
			return View();
		}

		public IActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View("~/Views/Shared/Error.cshtml");
		}
	}
}