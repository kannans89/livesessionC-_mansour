using SimpleAPIProject.Domain;

namespace SimpleAPIProject.Services
{
	public class CustomerService
	{

		private List<Customer> _customers =new List<Customer>();

		public CustomerService()
		{
            Console.WriteLine("Customer Service created...");

			_customers.Add(new Customer() { Id=1,FirstName="John",LastName="Doe"});
			_customers.Add(new Customer() { Id=2,FirstName="Jane",LastName="Doe"});

		  }

		public List<Customer> GetCustomers()
		{
			return _customers;
		}

		public Customer GetCustomerById(int id)
		{
			Customer customer = new Customer();

			foreach(Customer c in _customers)
			{
				if(c.Id == id)
				{
					return c;
				}
			}
			return customer;
		}

		public void AddCustomer(Customer customer)
		{
			_customers.Add(customer);
		}
	}
}
