namespace homework9__практическое_занятие_ООП_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Person person = new Person("Человек", "мужчина");
           person.Greet();
           person.SetAge();
           Student student = new Student("Ученица1", "женщина", 787878);
           student.Greet();
           student.SetAge();
           student.Study();
           student.ShowAge();
           Teacher teacher = new Teacher("Философии", "Учитель1", "мужчина");
           teacher.Greet();
           teacher.SetAge();
           teacher.Explain();
        }
    }
}
