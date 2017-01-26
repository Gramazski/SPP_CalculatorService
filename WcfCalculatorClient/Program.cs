using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfCalculatorClient.ServiceReference1;

namespace WcfCalculatorClient
{
    class Program
    {
        private static CalculatorClient calculatorClient;

        static void Main(string[] args)
        {
            calculatorClient = new CalculatorClient();
            String request = String.Empty;
            Boolean isEnd = false;
            double result;

            Console.WriteLine("Start calculating");

            while (!isEnd)
            {
                try
                {
                    request = Console.ReadLine();
                    String[] parameters = parseRequest(request);
                    result = perfomCommand(parameters[0], parameters[1].Split(','));
                    Console.WriteLine("Result: " + result);
                }
                catch (FaultException<CalculationFault> e)
                {
                    Console.WriteLine(e.Detail.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Illegal count of parameters count.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Illegal command: " + ex.Message);
                }

                Console.WriteLine("End calculating?(true for end)");
                isEnd = Convert.ToBoolean(Console.Read());
            }

            calculatorClient.Close();

            Console.ReadKey();
        }

        private static String[] parseRequest(String request)
        {
            return request.Split(' ');
        }

        private static double perfomCommand(String command, String[] args)
        {
            double result;

            switch (command)
            {
                case "ADD":
                    result = calculatorClient.Add(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
                    break;
                case "SUB":
                    result = calculatorClient.Substract(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
                    break;
                case "MUL":
                    result = calculatorClient.Multiply(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
                    break;
                case "DIV":
                    result = calculatorClient.Divide(Convert.ToDouble(args[0]), Convert.ToDouble(args[1]));
                    break;
                case "SQRT":
                    result = calculatorClient.Sqrt(Convert.ToDouble(args[0]));
                    break;
                default:
                    throw new ArgumentException(command);
                    break;
            }

            return result;
        }
    }
}
