using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace API.DTOs;

public class CreateProductDto {

  [Required]
  public string Name { get; set; }

  [Required]
  public string Description { get; set; }

  [Required]
  public IFormFile File { get; set; }

  [Required]
  [Range(1, double.PositiveInfinity)]
  public long Price { get; set; }

  [Required]
  public string Brand { get; set; }

  [Required]
  public string Type { get; set; }

  [Required]
  [Range(0, 200)]
  public int QuantityInStock { get; set; }
}