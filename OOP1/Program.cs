using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Customer(), new CarCreditManager());
            customerManager.GiveCredit();


            Console.ReadLine();
        }

    }
    class CreditManager 
    {
        public void Calculate(int creditType)
        {
            if (creditType == 1)
            {

            }
            if (creditType == 2)
            {

            }
            Console.WriteLine("Hesaplandı");

        }
        public void Save()
        {
            Console.WriteLine("Kredi Verildi");
        }

    }
    interface ICreditManger
    {
        void Calculate();
        void Save();
    }
    abstract class BaseCreditManager : ICreditManger
    {
        public abstract void Calculate();
        
        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi");

        }
   
    
    }


    

    }
    
    class TeacherCreditManager :BaseCreditManager ,ICreditManger
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen Kredisi hesaplandı");
        }

    public override void Save()
    {
        base.Save();
    }


}
    class MilitaryCreditManager : BaseCreditManager, ICreditManger
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı");
        }
        
    }
    class CarCreditManager : BaseCreditManager, ICreditManger
    {
        public override void Calculate()
        {
            Console.WriteLine("Araba kredisi hesaplandı");
        }
       
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public string TaxNumber { get; set; }
        public string city { get; set; }

    }

    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }

    }
    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
    class CustomerManager 
    {
        private Customer _customer;
        private ICreditManger _creditManger;
        public CustomerManager(Customer customer,ICreditManger creditManger)
        {
            _customer = customer;
            _creditManger = creditManger;
        }
       public void Save()
        {
            Console.WriteLine("Müşteri Kaydedildi : ");
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri silindi: " );
        }
        public void GiveCredit()
        {
            _creditManger.Calculate();
            Console.WriteLine("Kredi Verildi");
        }
    }

