using System;

namespace temiz_homework
{
    class Program
    {
        static void day_of_week(int day, int month, int year)
        {
            //for the day of the week (Zeller's Algorithm)
            double Y = 0, y = 0, d = 0, m = 0, w = 0, c = 0;
            string dayofweek = "";

            Y = year;
            y = Y % 100;
            c = Y / 100;
            c = Math.Floor(c);
            d = day;
            m = month;
            w = (Math.Floor((13 * (m + 1)) / 5) + Math.Floor(y / 4) + Math.Floor(c / 4) + d + y - (2 * c)) % 7;
            switch (w)
            {
                case 0:
                    dayofweek = "Saturday";
                    break;
                case 1:
                    dayofweek = "Sunday";
                    break;
                case 2:
                    dayofweek = "Monday";
                    break;
                case 3:
                    dayofweek = "Tuesday";
                    break;
                case 4:
                    dayofweek = "Wednesday";
                    break;
                case 5:
                    dayofweek = "Thursday";
                    break;
                case 6:
                    dayofweek = "Friday";
                    break;
            }
            Console.WriteLine(dayofweek);
        }

        static int day_transfer(int day, int monthday) //calculates the remaining days from the previous month
        {
            return day = day - monthday;
        }

        static void month_search_method(int month) //prints the month
        {
            switch (month)
            {
                case 3:
                    Console.Write("March ");
                    break;

                case 4:
                    Console.Write("April ");
                    break;

                case 5:
                    Console.Write("May ");
                    break;

                case 6:
                    Console.Write("June ");
                    break;

                case 7:
                    Console.Write("July ");
                    break;

                case 8:
                    Console.Write("August ");
                    break;

                case 9:
                    Console.Write("September ");
                    break;

                case 10:
                    Console.Write("October ");
                    break;

                case 11:
                    Console.Write("November ");
                    break;

                case 12:
                    Console.Write("December ");
                    break;

                case 13:
                    Console.Write("January ");
                    break;

                case 14:
                    Console.Write("February ");
                    break;

                default:
                    Console.Write("You entered wrong");
                    break;
            }
        }

        static int month_day_method(int month, int year) //find how many days in the month
        {
            int totalday = 0;
            switch (month)
            {
                case 3: //march
                    totalday = 31;
                    break;
                case 4: //april
                    totalday = 30;
                    break;
                case 5: //may
                    totalday = 31;
                    break;
                case 6: //june
                    totalday = 30;
                    break;
                case 7: //july
                    totalday = 31;
                    break;
                case 8: //august
                    totalday = 31;
                    break;
                case 9: //september
                    totalday = 30;
                    break;
                case 10: //october
                    totalday = 31;
                    break;
                case 11: //november
                    totalday = 30;
                    break;
                case 12: //december
                    totalday = 31;
                    break;
                case 13: //january
                    totalday = 31;
                    break;
                case 14: //february
                    if (year % 4 == 0)
                    {
                        if (year % 4000 != 0) //years divisible by both 400 and 4000 without a remainder are not considered leap years
                        {
                            if (year % 100 == 0) //from years with a multiple of 100
                            {
                                if (year % 400 == 0) //only those that are divisible by 400 without a remainder are leap years
                                {
                                    totalday = 29;
                                }
                                else
                                {
                                    totalday = 28;
                                }
                            }
                            else if (year % 4 == 0)
                            {
                                totalday = 29;
                            }
                        }
                        else
                            totalday = 28;
                    }
                    else
                        totalday = 28;
                    break;
            }
            return totalday;
        }

        static void season_method(int month, int first_month)
        {
            switch (first_month) //prints the season of the first entered month
            {
                case 4:
                    Console.WriteLine("Spring");
                    break;
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 7:
                    Console.WriteLine("Summer");
                    break;
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 10:
                    Console.WriteLine("Autumn");
                    break;
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                case 13:
                    Console.WriteLine("Winter");
                    break;
                case 14:
                    Console.WriteLine("Winter");
                    break;
            }

            //prints the season
            if (month == 3)
            {
                Console.WriteLine("\nSpring");
            }
            else if (month == 6)
            {
                Console.WriteLine("\nSummer");
            }
            else if (month == 9)
            {
                Console.WriteLine("\nAutumn");

            }
            else if (month == 12)
            {
                Console.WriteLine("\nWinter");
            }
        }

        static void Main(string[] args)
        {
            //for day, month, year
            int day1 = 0, year1 = 0, day2 = 0, year2 = 0, n = 0, mnth1 = 0, mnth2 = 0, i = 0, j = 0, j_is_zero = 0, k = 0, month_day1 = 0, month_day2 = 0, temp_day = 0, temp_month = 0, temp_year = 0, total_day1 = 0, total_day2 = 0, temp_A = 0, temp_B = 0;
            string month1 = "", month2 = "", day1_tryparse = "", day2_tryparse = "", n_tryparse = "";
            bool first_month = true, stop_loop = true, stop_loop2 = true;

            Console.WriteLine("Please enter your data in the order of Day-Month-Year.");
            Console.Write("Day1: ");
            day1_tryparse = Console.ReadLine();
            while (day1 < 1 || day1 > 31)
            {
                if (Int32.TryParse(day1_tryparse, out day1)) //checks if integer value is input
                {
                    while (day1 < 1 || day1 > 31) //is the entered value between 1-31?
                    {
                        day1 = 1;
                        Console.Write("Day is wrong! Please enter the day1 again\nDay1:");
                        day1_tryparse = Console.ReadLine();
                        Int32.TryParse(day1_tryparse, out day1);
                    }
                }
                else //if value is not int re-enter
                {
                    Console.Write("Day is wrong! Please enter the day1 again\nDay1: ");
                    day1_tryparse = Console.ReadLine();
                }
            }

            while (mnth1 < 3 || mnth1 > 14) //months from 3 to 14 according to the Zeller algorithm
            {
                Console.Write("Month1: ");
                month1 = Console.ReadLine();
                switch (month1.ToLower())
                {
                    case "march":
                        mnth1 = 3;
                        break;

                    case "april":
                        mnth1 = 4;
                        break;

                    case "may":
                        mnth1 = 5;
                        break;

                    case "june":
                        mnth1 = 6;
                        break;

                    case "july":
                        mnth1 = 7;
                        break;

                    case "august":
                        mnth1 = 8;
                        break;

                    case "september":
                        mnth1 = 9;
                        break;

                    case "october":
                        mnth1 = 10;
                        break;

                    case "november":
                        mnth1 = 11;
                        break;

                    case "december":
                        mnth1 = 12;
                        break;

                    case "january":
                        mnth1 = 13;
                        break;

                    case "february":
                        mnth1 = 14;
                        break;

                    default:
                        Console.WriteLine("Month is wrong! Please enter the month again");
                        break;
                }
            }

            Console.Write("Year1: ");
            year1 = Convert.ToInt32(Console.ReadLine());
            while (year1 < 2015)
            {
                Console.Write("please enter the year1 more than 2015\nYear1: ");
                year1 = Convert.ToInt32(Console.ReadLine());
            }

            month_day1 = month_day_method(mnth1, year1); //find how many days in the month
            while (day1 > month_day1) //if the entered day exceeds the month's limit, you have to re-enter
            {
                day1 = 0;
                Console.Write("Day is wrong! Please enter the day1 again\nDay1: ");
                day1_tryparse = Console.ReadLine();
                while (day1 < 1 || day1 > 31)
                {
                    if (Int32.TryParse(day1_tryparse, out day1)) //checks if integer value is input
                    {
                        while (day1 < 1 || day1 > 31) //is the entered value between 1-31?
                        {
                            day1 = 1;
                            Console.Write("Day is wrong! Please enter the day1 again\nDay1:");
                            day1_tryparse = Console.ReadLine();
                            Int32.TryParse(day1_tryparse, out day1);
                        }
                    }
                    else //if value is not int re-enter
                    {
                        Console.Write("Day is wrong! Please enter the day1 again\nDay1: ");
                        day1_tryparse = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("\nPlease enter your data in the order of Day-Month-Year.");
            Console.Write("Day2: ");
            day2_tryparse = Console.ReadLine();
            while (day2 < 1 || day2 > 31)
            {
                if (Int32.TryParse(day2_tryparse, out day2)) //checks if integer value is input
                {
                    while (day2 < 1 || day2 > 31) //is the entered value between 1-31?
                    {
                        day2 = 1;
                        Console.Write("Day is wrong! Please enter the day2 again\nDay1:");
                        day2_tryparse = Console.ReadLine();
                        Int32.TryParse(day2_tryparse, out day2);
                    }
                }
                else //if value is not int re-enter
                {
                    Console.Write("Day is wrong! Please enter the day2 again\nDay1: ");
                    day2_tryparse = Console.ReadLine();
                }
            }

            while (mnth2 < 3 || mnth2 > 14) //months from 3 to 14 according to the Zeller algorithm
            {
                Console.Write("Month2: ");
                month2 = Console.ReadLine();
                switch (month2.ToLower())
                {
                    case "march":
                        mnth2 = 3;
                        break;

                    case "april":
                        mnth2 = 4;
                        break;

                    case "may":
                        mnth2 = 5;
                        break;

                    case "june":
                        mnth2 = 6;
                        break;

                    case "july":
                        mnth2 = 7;
                        break;

                    case "august":
                        mnth2 = 8;
                        break;

                    case "september":
                        mnth2 = 9;
                        break;

                    case "october":
                        mnth2 = 10;
                        break;

                    case "november":
                        mnth2 = 11;
                        break;

                    case "december":
                        mnth2 = 12;
                        break;

                    case "january":
                        mnth2 = 13;
                        break;

                    case "february":
                        mnth2 = 14;
                        break;

                    default:
                        Console.WriteLine("Month is wrong");
                        break;
                }
            }

            Console.Write("year2: ");
            year2 = Convert.ToInt32(Console.ReadLine());
            while (year2 < 2015)
            {
                Console.Write("please enter the year2 more than 2015\nYear2: ");
                year2 = Convert.ToInt32(Console.ReadLine());
            }

            month_day2 = month_day_method(mnth2, year2); //find how many days in the month
            while (day2 > month_day2)
            {
                day2 = 0;
                Console.Write("Day is wrong! Please enter the day2 again\nDay1: ");
                day2_tryparse = Console.ReadLine();
                while (day2 < 1 || day2 > 31)
                {
                    if (Int32.TryParse(day2_tryparse, out day2)) //checks if integer value is input 
                    {
                        while (day2 < 1 || day2 > 31) //is it entered the value between 1-31?
                        {
                            day2 = 1;
                            Console.Write("Day is wrong! Please enter the day2 again\nDay1:");
                            day2_tryparse = Console.ReadLine();
                            Int32.TryParse(day2_tryparse, out day2);
                        }
                    }
                    else //if value is not int re-enter
                    {
                        Console.Write("Day is wrong! Please enter the day2 again\nDay1: ");
                        day2_tryparse = Console.ReadLine();
                    }
                }
            }

            Console.Write("\nn: ");
            n_tryparse = Console.ReadLine();
            while (n < 1 || n > 31)
            {
                if (Int32.TryParse(n_tryparse, out n)) //checks if integer value is input
                {
                    while (n < 1 || n > 31) //is it entered the value between 1-31?
                    {
                        n = 1;
                        Console.Write("Day is wrong! Please enter the n again\nn:");
                        day2_tryparse = Console.ReadLine();
                        Int32.TryParse(day2_tryparse, out day2);
                    }
                }
                else //if value is not int re-enter
                {
                    Console.Write("Day is wrong! Please enter the n again\nn: ");
                    n_tryparse = Console.ReadLine();
                }
            }

            //Which of the entered dates compares to greater (Accepted 30 days each month)
            if (mnth1 == 13) //if January is entered, the temp_A is 30 days
            {
                temp_A = 30;
            }
            else if (mnth1 == 14) //if February is entered, the temp_A is 60 days
            {
                temp_A = 60;
            }
            else
            {
                temp_A = mnth1 * 30; //if it is one of the other months, multiply by 30 for each month
            }
            total_day1 = (year1 * 365) + temp_A + day1; //convert all months to days from the month the user entered to January


            if (mnth2 == 13)
            {
                temp_B = 30;
            }
            else if (mnth2 == 14)
            {
                temp_B = 60;
            }
            else
            {
                temp_B = mnth2 * 30;
            }
            total_day2 = (year2 * 365) + temp_B + day2;

            if (total_day1 > total_day2) //Which date is bigger?
            {
                temp_day = day1;
                temp_month = mnth1;
                temp_year = year1;
                day1 = day2;
                mnth1 = mnth2;
                year1 = year2;
                day2 = temp_day;
                mnth2 = temp_month;
                year2 = temp_year;
            }

            Console.WriteLine();
            for (i = year1; i <= year2; i++) //for years
            {
                for (j = mnth1; j <= 14; j++) //for months
                {
                    if (j == 13 && mnth1 != 13) //If the month is january, increment the year by 1, but not if the user's first login is january
                    {
                        i += 1; //increase year by 1
                    }
                    while (first_month) //enters once for the first month and writes the season
                    {
                        season_method(j_is_zero, j); //calculates the seasons
                        first_month = false;
                    }
                    season_method(j, j_is_zero);
                    for (k = day1; k <= month_day1; k += n) //for days
                    {
                        Console.Write("{0} ", k); //prints days
                        month_search_method(j); //prints months
                        Console.Write("{0} ", i); //prints years
                        day_of_week(k, j, i); //prints day of week
                        if (i == year2 && j == mnth2 && ((k + n) % month_day1) >= day2) //Did it arrive on the 2nd date?
                        {
                            stop_loop = false; //to exit the day loop
                            break;
                        }
                    }

                    if (stop_loop == false) //to exit the month loop
                    {
                        stop_loop2 = false;
                        break;
                    }

                    day1 = day_transfer(k, month_day1); //calculates the remaining days from the previous month
                    j += 1; //we add 1 to the month to control February
                    if (j > 14) //if the month number passed February
                    {
                        j = 3; //returns to March
                    }
                    month_day1 = month_day_method(j, year1); //find how many days in the new month
                    j -= 1; //1 was added to check February, ​now it's back to how it was
                }

                if (stop_loop2 == false) //to exit the year loop
                {
                    break;
                }
                if (j > 14) //if the months exceed the limit, revert the loop to the beginning according to the Zeller algorithm
                {
                    mnth1 = 3;
                }
            }
            Console.ReadLine();
        }
    }
}