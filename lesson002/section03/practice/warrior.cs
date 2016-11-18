namespace Section03.Practice
{
  public class Warrior : Unit
  {
    public Warrior(int hp, int power) : base(hp, power) {}

    override public void powerUp()
    {
      power *= 3;
    }
  }
}

