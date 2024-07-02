using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AccountEncapsulationApp.Model
{
	public class Account
	{
		private int _accoutNumber;
		private string _name;
		private double _balance=500;





		public string Name {


			get {
				return _name;
			}

			set { 
			 if(value.Length>=3)
				 _name=value;
                else
                {
                    throw new Exception("Name must be greater than 3 characters");
                }

            }
		
		
		}



		public void Deposit(double amount)
		{
			if (amount > 0)
			{
				_balance += amount;
			}
			else
				throw new Exception("amount must be greater than 0");
		}


		public void Withdraw(double amount) {

			if (_balance - amount > 500) { 
			
			   _balance -= amount;
			}
			else
				throw new Exception("Insufficient balance");

		
		}


		public double Balance {

			get { 
			  return _balance;	
			}
		}

		public int AccountNumber {

			get {
				return _accoutNumber;
			}
			set {
				if (value > 0)
				{
					_accoutNumber = value;
				}
				else
					throw new Exception("account no must be greated than 0");
			}
		}

	}
}
