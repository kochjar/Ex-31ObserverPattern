namespace Ex_31ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student(p, "Jens");

            Student s2 = new Student(p, "Niels");

            Student s3 = new Student(p, "Susan");

            p.MessageChanged += s1.Update;
            p.MessageChanged += s2.Update;
            p.MessageChanged += s3.Update;
            /*
            p.Attach(s1);

            p.Attach(s2);

            p.Attach(s3);
            */

            p.Message = "Så er der julefrokost!";

            p.MessageChanged -= s2.Update;

            //p.Detach(s2);

            p.Message = "Så er der fredagsbar!";


        }

    }
}