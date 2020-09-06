using System;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public DateTime Birthday { get; set; } = DateTime.Now;
       public int HungerLevel { get; set; } = 0;
       public int HappyLevel { get; set; } = 0;
    }
}