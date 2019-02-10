using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2 {
    class Attendee : Person {
        public char[] Grades { get; set; }
        public Attendee(string name, string email, char[] grades) : base(name, email) {
            Name = name;
            Email = email;
            Grades = grades;
        }

        public void GetGradeAverage(char[] grades) {
            int[] gradeNum = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++) {
                Char.ToUpper(grades[i]);

                // compared to the assignments the grades and their numerals are flipped
                // ...because isn't that how it works in the land of Freedom(TM)?
                switch (grades[i]) {
                    case 'A':
                        gradeNum[i] = 6;
                        break;
                    case 'B':
                        gradeNum[i] = 5;
                        break;
                    case 'C':
                        gradeNum[i] = 4;
                        break;
                    case 'D':
                        gradeNum[i] = 3;
                        break;
                    case 'E':
                        gradeNum[i] = 2;
                        break;
                    case 'F':
                        gradeNum[i] = 1;
                        break;
                }
            }

            double avg = gradeNum.Average();
            char avgLetter = 'F';
            if (avg > 0 && avg < 1.5) {
                avgLetter = 'F';
            } else if (avg >= 1.5 && avg < 2.5) {
                avgLetter = 'E';
            } else if (avg >= 2.5 && avg < 3.5) {
                avgLetter = 'D';
            } else if (avg >= 3.5 && avg < 4.5) {
                avgLetter = 'C';
            } else if (avg >= 4.5 && avg < 5.5) {
                avgLetter = 'B';
            } else if (avg >= 5.5 && avg <= 6) {
                avgLetter = 'A';
            }

            Console.WriteLine("Attendee {0}, {1}", this.Name, this.Email);
            Console.WriteLine("    Numeral grade average: " + Math.Round(avg, 2));
            Console.WriteLine("    Letter grade average: " + avgLetter);
        } // public void GetGradeAverage

        public static Attendee AddAttendee(string name, string email, char[] grades) {
            Attendee sacrifice = new Attendee(name, email, grades);
            return sacrifice;
        }

    } // class Attendee : Person
} // namespace T2
