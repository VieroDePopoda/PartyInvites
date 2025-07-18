﻿using System.ComponentModel.DataAnnotations;
using System.Net;

namespace PartyInvites.Models
{
  public class GuestResponse
  {
    [Required(ErrorMessage = "Please enter your name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter your email address")]
    [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid emailaddress")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter your phone number")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Please specify whether you'll attend")]
    public bool? WillAttend { get; set; }
  }
}
