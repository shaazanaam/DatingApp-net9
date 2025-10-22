namespace API.Entities;
// typically the n amespace represents the physical location of the place the file is located inside the 
// these are refered to as the entity class becasuse they represent  a distint identifiable 
// each instance of this entity represents the row in a table in the database
// each property that this class has is going to be represnting a column  in the table 
// 
public class AppUserssss
{
      public string Id { get; set; } = Guid.NewGuid().ToString();
      public required string DisplayName { get; set; }
      public required string Email { get; set; }

}
