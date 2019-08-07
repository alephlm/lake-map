using System.Linq;
using System.Text.RegularExpressions;
using LakeMap.Services;
using Microsoft.AspNetCore.Mvc;

namespace LakeMap.Controllers
{
	[Route("api/[controller]")]
	public class MapController : Controller
	{
		// POST api/map
		[HttpPost]
		public IActionResult Post([FromBody]string value)
		{
			var matrix = Utils.CreateMatrix(value);
			return Json(Calculations.CalculateLakeArea(matrix));
		}
	}
}
