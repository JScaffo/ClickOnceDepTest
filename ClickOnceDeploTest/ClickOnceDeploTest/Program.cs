using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOnceDeploTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                Console.WriteLine(ApplicationDeployment.CurrentDeployment.CurrentVersion);
            else
                Console.WriteLine("Sin deployment");

            if (ApplicationDeployment.CurrentDeployment.CheckForUpdate()) {
                Console.Write("Descargando nueva version!!");
                ApplicationDeployment.CurrentDeployment.Update();
            }

            Console.ReadLine();

        }


    }
}
