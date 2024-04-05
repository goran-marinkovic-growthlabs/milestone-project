namespace Milestone
{
  class Date
  {
    public int DayOfMonth { get; set; }
    public Season Season { get; set; }
  }

  public enum Season
  {
    Spring,
    Summer,
    Autumn,
    Winter
  }

}
