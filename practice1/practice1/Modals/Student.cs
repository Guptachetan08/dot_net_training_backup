﻿namespace StudentManagementSystemAPI.Modals
{
    public class Student
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
    }
}
