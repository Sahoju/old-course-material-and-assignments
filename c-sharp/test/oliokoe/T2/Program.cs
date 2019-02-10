// Odottamani pisteet 7/7p
// Kaikki toimii vaaditusti.
// Sinänsä olisi voinut tehdä paremmaksi pääohjelman tulostus, mutta toisaalta taas, tehtävässä ei vaadittu sitä :^)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2 {
    class Program {
        static void Main(string[] args) {
            List<Attendee> attendees = new List<Attendee>();
            char[] grades1 = { 'B', 'B', 'A', 'B', 'A', 'C' };
            char[] grades2 = { 'A', 'A', 'B', 'D', 'C', 'E' };
            attendees.Add(Attendee.AddAttendee("Matti Mainio", "matti@mainio.com", grades1));
            attendees.Add(Attendee.AddAttendee("Kirsi Kernel", "kirsi@kernel.com", grades2));
            attendees[0].GetGradeAverage(attendees[0].Grades);
            attendees[1].GetGradeAverage(attendees[1].Grades);
        } // static void Main
    } // class Program
} // namespace T2

/*

Console prints:

Attendee Matti Mainio, matti@mainio.com
    Numeral grade average: 5,17
    Letter grade average: B
Attendee Kirsi Kernel, kirsi@kernel.com
    Numeral grade average: 4,33
    Letter grade average: C

*/
