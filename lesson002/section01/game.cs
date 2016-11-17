namespace Section01
{
  using System;

  public class Game
  {
    public static void Main()
    {
      Soldier soldier = new Soldier(100, 10); // Soldierをインスタンス化

      Console.WriteLine(soldier.hp);     // hpの値を確認
      Console.WriteLine(soldier.power);  // powerの値を確認
    }
  }
}

