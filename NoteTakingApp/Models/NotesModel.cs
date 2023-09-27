using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NoteTakingApp.Models;

public class NotesModel
{
    [Required]
    public string Note { get; set; }

}
