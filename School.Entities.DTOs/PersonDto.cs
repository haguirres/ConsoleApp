﻿namespace School.Entities.DTOs
{
    public class PersonDto
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public int AddressId { get; set; }
        public byte[] CURP { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }
    }
    }