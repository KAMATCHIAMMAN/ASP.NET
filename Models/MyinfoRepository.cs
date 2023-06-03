using System.Security.Cryptography.X509Certificates;

namespace DependencyInjection.Models
{
    public class MyinfoRepository: IMyinfoInterface
    {
        private Mydetails personaldetails;

        public MyinfoRepository()
        {
            personaldetails = new Mydetails()
            {
                myName = "kamatchi",
                gender = "female",
                age = 22,
                desgination = "SDE"

            };
        }
        public Mydetails GetDetails()
        {
            return personaldetails;
        }
    }
}
