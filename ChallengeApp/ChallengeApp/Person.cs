using System.Diagnostics;

namespace ChallengeApp
{
    public abstract class Person
    {
        protected Person(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            
            if (age >= 0 && age <= 110)
            {
                this.Age = age;
            }
            else
            {
                throw new Exception("Incorrectly stated age");
            }
            if (sex == 'M' || sex == 'K')
            {
                this.Sex = sex;
            }
            else
            {
                throw new Exception("Incorrectly stated sex");
            }
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
    }
}
