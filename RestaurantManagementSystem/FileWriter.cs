using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class FileWriter
    {
        public static void WriteToFile(string filename, Customer customer)
        {
            using (StreamWriter streamwriter = new StreamWriter(filename))
            {
                streamwriter.WriteLine(customer);
            }
        }
    }
}
