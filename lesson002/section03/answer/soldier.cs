namespace Section03.Answer
{
  public class Soldier : Unit
  {
    public Soldier(int hp, int power) : base(hp, power) {}

    override public void powerUp()
    {
      power *= 2;
    }
  }
}

