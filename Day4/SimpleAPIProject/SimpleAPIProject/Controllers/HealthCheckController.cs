using Microsoft.AspNetCore.Mvc;

namespace SimpleAPIProject.Controllers
{

	[Route("api/v1/[controller]")]//Attributes,swagger
	[ApiController]//Attributes
	public class HealthCheckController:ControllerBase
	{

		[HttpGet]
		public string Get()
		{
			return "Healthy and Good to Go...";
		}

		[HttpPost]
		public string Post()
		{
			return "Post:Healthy and Good to Go...";
		}

		[HttpPut]
		public string Put()
		{
			return "Put:Healthy and Good to Go...";
		}

		[HttpDelete]
		public string Delete()
		{
			return "Delete:Healthy and Good to Go...";
		}
	}
}
