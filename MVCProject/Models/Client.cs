﻿namespace MVCProject.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public List<Purchase>? Purchases { get; set; }
    }
}
