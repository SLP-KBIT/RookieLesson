namespace Section02
{
  using System;

  public class Game
  {
    public static void Main()
    {
      Soldier soldier = new Soldier(100, 10); // Soldierをインスタンス化

      Console.WriteLine(soldier.getHp());     // hpの値を確認
      Console.WriteLine(soldier.getPower());  // powerの値を確認
    }
  }
}

