using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAsuthenticated = false;
Console.WriteLine(message1);

if (isAsuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Furkan");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net 8 vs...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 17 vs..."; 
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 1.12 vs...";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new(new DapperCourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationaIdentity = "123456985";
customer1.FirstName = "Furkan";
customer1.LastName = "Demir";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationaIdentity = "5698132165";
customer2.FirstName = "İrem";
customer2.LastName = "Karaca";
customer2.CustomerNumber = "885423";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "kodlama.io";
customer3.CustomerNumber = "5265252";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "abc";
customer4.CustomerNumber = "58521425";
customer4.TaxNumber = "15253542";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}


