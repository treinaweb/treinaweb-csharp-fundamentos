using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            var ativo = false;
            var a = 3;
            var b = 5;

            //     OPERADOR AND (E)
            //------------------------- |
            //OP1   | OP2   | RESULTADO |
            //------------------------- |
            //True  | True  | True      |
            //True  | False | False     |
            //False | True  | False     |
            //False | False | False     |
            //------------------------- |

            //     OPERADOR OR (OU)
            //------------------------- |
            //OP1   | OP2   | RESULTADO |
            //------------------------- |
            //True  | True  | True      |
            //True  | False | True      |
            //False | True  | True      |
            //False | False | False     |
            //------------------------- |

            Console.WriteLine(ativo == true || a > b);
        }
    }
}
