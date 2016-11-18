namespace Section03.Practice
{
  using System;

  public class Game
  {
    public static void Main()
    {
      Soldier soldier = new Soldier(100, 10);
      Warrior warrior = new Warrior(100, 10);
      Berserker berserker = new Berserker(100, 10);

      UnitAction(soldier);
      UnitAction(warrior);
      UnitAction(berserker);
    }

    public static void UnitAction(Unit unit)
    {
      unit.powerUp();
      Console.WriteLine("hp : " + unit.getHp() + ", power : " + unit.getPower());
    }
  }
}

