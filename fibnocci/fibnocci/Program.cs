// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1.fibnacci series\n2.perfect number\n3.prime number\n");
Console.WriteLine("Enter Your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        fibnocci.fibseries fs = new fibnocci.fibseries();
        fs.series();
        break;

    case 2:
        fibonacci.perfectnumber pf = new fibonacci.perfectnumber();
        pf.perfect();
        break;
    case 3:
        fibnocci.primenumber primenumber = new fibnocci.primenumber();
        primenumber.prime();
        break;

}
