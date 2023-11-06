using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_University.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public bool Gender { get; set; }
        public string GenderName
        {
            get
            {
                if (Gender)
                {
                    return "زن";
                }
                return "مرد";
            }
        }
        public bool IsMarried { get; set; }
        public string MarriedName
        {
            get
            {
                if (IsMarried)
                {
                    return "متأهل";
                }
                return "مجرد";
            }
        }
        public Proof Proof { get; set; }
        public string ProofName
        {
            get
            {
                if (Proof == null)
                {
                    return "بدون مقطع";
                }

                return Proof.ProofName;
            }
        }
    }
}
