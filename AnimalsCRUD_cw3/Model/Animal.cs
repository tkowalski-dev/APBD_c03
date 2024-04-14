﻿using System.ComponentModel.DataAnnotations;

namespace AnimalsCRUD_cw3.Model;

public class Animal
{
    public int IdAnimal { get; set; }
    
    [Required]
    [MaxLength(200)]
    string Name { get; set; }
    
    [MaxLength(200)]
    public string Description { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Category { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Area { get; set; }
}