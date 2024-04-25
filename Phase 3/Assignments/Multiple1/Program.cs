using System;
namespace Multiple1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal = new PersonalInfo("Selva","male",new DateTime(2001,11,22),"92646444564","Unmarried");
        personal.ShowInfo();
        RegisterPerson person = new RegisterPerson(personal.Name,personal.Gender, personal.DOB, personal.Phone,personal.MaritalStatus,"Vel","Brinda","Theni",1,new DateTime(2023,11,22));
        person.ShowInfo();
        //IFamilyInfo family= new IFamilyInfo();
    }
}