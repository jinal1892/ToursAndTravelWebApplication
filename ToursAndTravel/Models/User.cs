﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToursAndTravel.Models
{
  public class User
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Gender { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
  }
}