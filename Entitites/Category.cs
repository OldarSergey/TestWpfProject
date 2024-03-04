﻿using System.Collections;
using System.Collections.Generic;

namespace TestWpfProject.Entitites
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<HotelRoom> HotelRooms { get; set; }

    }
}