﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerLibrary.Models
{
   public class TeamModel
    {
        public  List<PersonModel> TeamMembers { get; set; }= new List<PersonModel>();

        public string  TeamName { get; set; }
    }
}
