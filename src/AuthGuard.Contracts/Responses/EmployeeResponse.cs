using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AuthGuard.Contracts.Responses
{
    public class EmployeeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public string GenderText
        {
            get
            {
                if (Gender.Equals(0))
                {
                    return "Male";

                }else if (Gender.Equals(1))
                {
                    return "Female";
                }

                else return "Other";
            }
        }
    }
}
