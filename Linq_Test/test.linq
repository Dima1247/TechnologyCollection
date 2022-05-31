<Query Kind="Program" />

void Main()
{
	var boolCheck = (new List<(string name, bool isOperator)>{
		("John", true),
		("Lisa", false),
		("Petr", true),
		("Petr", false),
		("Joe", false)
	}).OrderBy(el => el.isOperator);

	Console.WriteLine(boolCheck);
	Console.WriteLine(boolCheck.FirstOrDefault(el => el.name == "Petr"));

/*
	return;

	var people = new List<Person>();
	
	people.Add(new Person{Name = "Mika", Age = 20, Company = "FIVE"});
	people.Add(new Person{Name = "Lika", Age = 21, Company = "FIVE"});
	people.Add(new Person{Name = "Nika", Age = 20, Company = "Existek"});
	people.Add(new Person{Name = "Rika", Age = 19, Company = "Intetics"});
	people.Add(new Person{Name = "Mika", Age = 19, Company = "Existek"});
	//Console.WriteLine(people);
	
	var companies = new List<Company>();
	
	companies.Add(new Company{Name = "FIVE", Rate = 55, Bonuses = new [] {"Sick Leave", "Holiday"}});
	companies.Add(new Company{Name = "Existek", Rate = 40, Bonuses = new [] {"Sick Leave"}});
	companies.Add(new Company{Name = "Intetics", Rate = 80, Bonuses = new [] {"Sick Leave", "Salary"}});
	//Console.WriteLine(people);
	
	var masters = new List<Master>();
	
	masters.Add(new Master{Name = "Mika", Age = 20, Companies = new [] {companies[0], companies[1]}});
	masters.Add(new Master{Name = "Lika", Age = 21, Companies = new [] {companies[1], companies[2]}});
	masters.Add(new Master{Name = "Nika", Age = 20, Companies = new [] {companies[0], companies[1], companies[2]}});
	masters.Add(new Master{Name = "Rika", Age = 19, Companies = new [] {companies[1], companies[2]}});
	masters.Add(new Master{Name = "Mika", Age = 19, Companies = new [] {companies[0], companies[2]}});
	//Console.WriteLine(masters);
	
	var orderedPeople = people.OrderBy(person => person.Age)
	.ThenByDescending(person => person.Name);
	//.ThenBy(person => person.Name);
	//Console.WriteLine(orderedPeople);

	var groupedPeople = people.GroupBy(person => person.Age);
	//Console.WriteLine(groupedPeople);
	
	//var joinedPeople = people.Join(companies,
	//person => person.Company,
	//company => company.Name,
	//(person, company) => new { Name = person.Name, Age = person.Age, Company = person.Company, IsPrestigious = company.Rate > 50 });
	//Console.WriteLine(joinedPeople);
	
	//var joinedPeopleByCompanies = people.GroupJoin(companies,
	//person => person.Company, 
	//company => company.Name,
	//(person, companies) => new { Name = person.Name, Age = person.Age, Company = person.Company, Bonuses = companies.Select(company => company.Bonuses)});
	//Console.WriteLine(joinedPeopleByCompanies);
	*/
	var dateList = new List<DateItem>{
		new DateItem { Label = "Elem1", Date = DateTime.Now },
		new DateItem { Label = "Elem1", Date = DateTime.Now.AddHours(2) },
		new DateItem { Label = "Elem1", Date = DateTime.Now.AddHours(1) },
		new DateItem { Label = "Elem1", Date = DateTime.Now.AddHours(4) },
		new DateItem { Label = "Elem1", Date = DateTime.Now.AddHours(1)},
		new DateItem { Label = "Elem1", Date = DateTime.Now.AddHours(5) }
	}.OrderBy(i => i.Date);
	
	Console.WriteLine(dateList);
}

class DateItem {
	public string Label {get;set;}
	public DateTime Date {get;set;}	
}

class Person {
	public string Name {get;set;}
	public int Age {get;set;}
	public string Company {get;set;}
}

class Master {
	public string Name {get;set;}
	public int Age {get;set;}
	public IEnumerable<Company> Companies {get;set;}
}

class Company {
	public string Name {get;set;}
	public int Rate {get;set;}
	public IEnumerable<string> Bonuses {get;set;}
}