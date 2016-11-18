namespace Section03.Practice
{
  public class Berserker : Unit
  {
    public Berserker(int hp, int power) : base(hp, power) {}

    override public void powerUp()
    {
      power *= 4;
    }
  }
}

