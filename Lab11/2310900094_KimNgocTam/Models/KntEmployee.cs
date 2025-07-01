using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _2310900094_KimNgocTam.Models;

public partial class KntEmployee
{
    [Required(ErrorMessage = "This field can't be empty!")]
    public long KntEmpId { get; set; }

    [Required(ErrorMessage = "This field can't be empty!")]
    public string KntEmpName { get; set; } = null!;

    [Required(ErrorMessage = "This field can't be empty!")]
    public string KntEmpLevel { get; set; } = null!;

    [Required(ErrorMessage = "This field can't be empty!")]
    public DateOnly KntEmpStartDate { get; set; }

    [Required(ErrorMessage = "This field can't be empty!")]
    public bool KntEmpStatus { get; set; }
}
