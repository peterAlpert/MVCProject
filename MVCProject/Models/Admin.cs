﻿namespace MVCProject.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Car>? Cars { get; set; }
    }
}
