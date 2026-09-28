/*
* Name: Peter Ologeh
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 22, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
//PART 1 - Road Trip


Console.Write("What was the round trip distance in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is a mile per gallon for the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

 //doing the math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

 //doing the output
 System.Console.WriteLine("Gallons Needed: " + gallonsNeeded.ToString("F2"));
 System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));


//PART 2 - Pizza Party
Console.Write("How many people are going? ");
int peopleThatAreGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizza do we have? ");
int pizzaWeHave = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

const int pizzaSlices = 8;

//doing the math
double totalSlices = pizzaWeHave * pizzaSlices;

double slicesPerPerson = totalSlices / peopleThatAreGoing;

double pizzaCost = pizzaWeHave * pizzaPrice;

//doing the output
System.Console.WriteLine("Total slices: " + totalSlices.ToString("F2"));
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F2"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));


//PART 3 - Paycheck
Console.Write("How many hours have you worked this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your hourly rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;

//doing the math
double grossPay = hoursWorked * hourlyRate;

double taxWithheld = grossPay * taxRate;

double takeHomePay = grossPay - taxWithheld;

//doing the output
System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));


//Part 4 - The Whole Trip
//doing the math
double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleThatAreGoing;

double takeHomePayPerHour = takeHomePay / hoursWorked;

double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

//doing the output
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work to cover your share: " + hoursYouMustWork.ToString("C"));
