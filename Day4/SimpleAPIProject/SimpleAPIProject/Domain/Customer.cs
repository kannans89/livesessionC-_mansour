﻿namespace SimpleAPIProject.Domain
{
	public class Customer
	{

		private int _id;
		private string _firstName;
		private string _lastName;


		public Customer()
		{

		}


		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

	}
}
