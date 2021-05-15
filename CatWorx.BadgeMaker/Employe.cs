namespace CatWorx.BadgeMaker
{
    class Employee
    // properties and methods defined in a class 
    // are given the protection level of private, 
    // which means that they can only be 
    // accessed within the class itself.
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;
        public Employee(string firstName, string lastName, int id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }
        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}