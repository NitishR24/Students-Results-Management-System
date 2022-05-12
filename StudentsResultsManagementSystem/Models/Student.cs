﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentsResultManagementSystem.Models
{
    /// <summary>
    /// This class contains definition of Student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Roll number of the Student
        /// </summary>
        [DisplayName("ROLL NUMBER")]
        public string RollNo { get; set; }

        /// <summary>
        /// First Name of the Student
        /// </summary>
        [DisplayName("FIRST NAME")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the Student
        /// </summary>
        [DisplayName("LAST NAME")]
        public string LastName { get; set; }

        /// <summary>
        /// Email Id of the Student
        /// </summary>
        [DisplayName("EMAIL ID")]
        public string Email { get; set; }
        
        /// <summary>
        /// Math marks
        /// </summary>
       [DisplayName("MATH")]
        public int Math { get; set; }

        /// <summary>
        /// Physics marks
        /// </summary>
        [DisplayName("PHYSICS")]
        public int Physics { get; set; }

        /// <summary>
        /// Chemistry marks
        /// </summary>
        [ DisplayName("CHEMISTRY")]
        public int Chemistry { get; set; }

        /// <summary>
        /// Average marks of all the subjects.
        /// </summary>
        [DisplayName("AVERAGE MARKS")]
        public float Average { get => (Math + Physics + Chemistry) / 3; }
    }
}
