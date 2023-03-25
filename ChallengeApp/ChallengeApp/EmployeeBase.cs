namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        protected EmployeeBase(string name, string surname, int age, char sex)
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

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
