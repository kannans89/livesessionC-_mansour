using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleAPIProject.Domain;
using SimpleAPIProject.Services;

namespace SimpleAPIProject.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class CustomerListController : ControllerBase
	{

		private CustomerService _customerService;
		public CustomerListController(CustomerService service)
		{
			_customerService = service;
			Console.WriteLine("CustomerListController created...");
		}

		[HttpGet("allcustomers")]
		public List<Customer> Get()
		{

			
			return _customerService.GetCustomers();


		}

		[HttpGet("allcustomers/{customerid}")]
		public Customer GetCustomerById(int customerid)
		{
		

			return _customerService.GetCustomerById(customerid);
		}

		[HttpPost("addcustomer")]
		public Customer AddCustomer(Customer customer)
		{

			_customerService.AddCustomer(customer);
			return customer;
		}
	}
}
