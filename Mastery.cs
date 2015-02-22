namespace LeagueSharp
{
  /// <summary>
  /// This structure represents a mastery entry.
  /// 
  /// </summary>
  public class Mastery
  {
    public byte Id;
    public MasteryPage Page;
    public byte Points;

    public Mastery(byte id, MasteryPage page, byte points)
    {
    }
  }
}
