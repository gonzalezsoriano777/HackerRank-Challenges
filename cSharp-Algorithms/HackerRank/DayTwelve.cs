﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }

    }

    class Student: Person
    {

        private int[] testScores;
        private int total = 0;
        private int average = 0;
        private char grade;

        public Student(string firstName, string lastName, int id, int[] scores)
                        :base(firstName, lastName, id)
        {
            this.testScores = scores;
        }

        public char Calculate()
        {
            int divide = testScores.Length;

            for(int i = 0; i < divide; i++)
            {
                total += testScores[i];
            }

            average = total / divide;

            if (average >= 90 && average <= 100)
            {
                grade = 'O';
            }
            if (average >= 80 && average < 90)
            {
                grade = 'E';
            }
            if (average >= 70 && average < 80)
            {
                grade = 'A';
            }
            if (average >= 55 && average < 70)
            {
                grade = 'P';
            }
            if (average >= 40 && average < 55)
            {
                grade = 'D';
            }
            if (average < 40)
            {
                grade = 'T';
            }

            return grade;


        }

    }
}
