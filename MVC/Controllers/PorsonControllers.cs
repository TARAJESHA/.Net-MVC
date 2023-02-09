using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace MVC.Controllers
{
    public class PorsonControllers : Controller
    {



        List<PersonModel> people = new List<PersonModel>()
        {
               new PersonModel {IdNumber=121, empyeeType="full", firstName = "DA", lastName = "Nguyen", phoneNumber=0123456789, emailAddress = "Study", mailingAddress = "Study for test"  ,baseSalary= 34 },
               new PersonModel {IdNumber=221, empyeeType="cont",  firstName = "David", lastName = "Smith", phoneNumber=0123456789, emailAddress = "Grocery", mailingAddress = "Buy apple and bananana" ,baseSalary= 34 },
               new PersonModel {IdNumber=321, empyeeType="full", firstName = "Tom", lastName = "Davidson", phoneNumber=0123456789, emailAddress = "Fix car", mailingAddress = "Headlight and mirror is broken"  ,baseSalary= 34  },
               new PersonModel {IdNumber=421, empyeeType="cont", firstName = "Maddie", lastName = "Madison", phoneNumber=0123456789, emailAddress = "Job application", mailingAddress = "Follow up on job interview ", baseSalary= 34}
        };
 

        // GET: Person
        public ActionResult Index()
        {
            return View(people);
        }

        [HttpGet]
       /* public string Create(PorsonModel per)
        {
            people.Add(new PorsonModel( IdNumber = pre.IdNumber, empyeeType = pre.empyeeType, firstName = pre.firstName, lastName = pre.lastName, phoneNumber = pre.phoneNumber, emailAddress = pre.emailAddress, mailingAddress = pre.mailingAddress, baseSalary = pre.baseSalary));

            return View();
        }*/

        [HttpPost]
        /*int IdNumber, string empyeeType, string firstName, string lastName, int phoneNumber, string emailAddress, string mailingAddress, double baseSalary*/
       /* public string Create(PersonModel pre)
        {
            people.Add(new PersonModel() { IdNumber = pre.IdNumber, empyeeType = pre.empyeeType, firstName = pre.firstName, lastName = pre.lastName, phoneNumber = pre.phoneNumber, emailAddress = pre.emailAddress, mailingAddress = pre.mailingAddress, baseSalary = pre.baseSalary });

            return "add succsees fully";

        }*/

        public string Details(int idNumber)
        {
            PersonModel pre = people.Find(emp => emp.IdNumber == idNumber);
            if (pre.empyeeType == "full")
            {
                return $"{ pre.baseSalary + pre.baseSalary * 0.3} employe type:{pre.empyeeType}" ;
            }
            else if( pre.empyeeType== "cont")
            {
                return $"{pre.baseSalary + pre.baseSalary * 0.1} employe type:{pre.empyeeType}";
            }
            else
            {
                return "Invalid employee ID";
            }
        }

        public string? Create(PersonModel1 pre)
        {
            people.Add(new PersonModel() { IdNumber = pre.IdNumber, empyeeType = pre.empyeeType, firstName = pre.firstName, lastName = pre.lastName, phoneNumber = pre.phoneNumber, emailAddress = pre.emailAddress, mailingAddress = pre.mailingAddress, baseSalary = pre.baseSalary });

            return "add succsees fully";
        }
    }
}
