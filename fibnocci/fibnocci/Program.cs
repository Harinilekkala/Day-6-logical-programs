﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1.fibnacci series\n2.perfect number\n3.prime number\n4. reverse of a number using while loop\n5. Coupon Number\n6. Stopwatch \n7. Vending Machine");
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

    case 4:
        fibnocci.reverse rev = new fibnocci.reverse();
        rev.reversenumber();
        break;

    case 5:
        fibnocci.CouponNumber cp = new fibnocci.CouponNumber();
        cp.coupon();
        break;

    case 6:
        fibnocci.stopwatchprogram stop = new fibnocci.stopwatchprogram();
        stop.calculatetime();
        break;

    case 7:
        fibnocci.vendingmachine vend = new fibnocci.vendingmachine();
        vend.moneychanger();
        break;




}
