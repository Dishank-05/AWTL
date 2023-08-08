using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace prac9_3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {

        double IService1.add(double num1, double num2)
        {
            return num1 + num2;
        }

        double IService1.sub(double num1, double num2)
        {
            return num1 - num2;
        }

        double IService1.mul(double num1, double num2)
        {
            return num1 * num2;
        }

        double IService1.divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
