using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> th_Words = words.FindAll(w => w.Contains("th"));


            //return
            return th_Words;
        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            List<string> name1 = names.GroupBy(n => n).Where(n => n.Count() == 1).Select(n => n.Key).ToList();

            List<string> name2 = names.GroupBy(n => n).Where(n => n.Count() > 1).Select(n => n.Key).ToList();

            List<string> duplicate_Free = name1.Concat(name2).ToList();

            //return
            return duplicate_Free;
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            Customer name_mike = customers.Find(c => c.FirstName == "Mike");


            //return
            return name_mike;
        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
            Customer updated_customer = customers.Find(c => c.Id == 3);

            updated_customer.FirstName = "John";
            updated_customer.LastName = "Smith";

            //return
            return updated_customer;
        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            //code

            //return
            return 42;
        }
        #endregion

        //    #region Bonus Problem 1
        //    //(5 points) Bonus Problem 1
        //    //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //    //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        //    public static string RunBonusProblem1(string word)
        //    {
        //        //code

        //        //return

        //    }
        //    #endregion

    }
}
