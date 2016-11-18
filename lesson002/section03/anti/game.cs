namespace Section03.Anti
{
  using System;

  public class Game
  {
    public static void Main()
    {
      Soldier soldier = new Soldier(100, 10);
      Warrior warrior = new Warrior(100, 10);

      WriteResult(soldier, warrior);

      soldier.powerUp();  // 攻撃力アップ(2倍)
      warrior.powerUp();  // 攻撃力アップ(3倍)

      soldier.damage(warrior.getPower());  // warriorがsoldierに攻撃
      warrior.damage(soldier.getPower());  // soldierがwarriorに攻撃

      WriteResult(soldier, warrior);
    }

    public static void WriteResult(Soldier soldier, Warrior warrior)
    {
      // 値の出力
      Console.WriteLine("---s1---");
      Console.WriteLine("hp : " + soldier.getHp() + ", power : " + soldier.getPower());
      Console.WriteLine("---s2---");
      Console.WriteLine("hp : " + warrior.getHp() + ", power : " + warrior.getPower());
    }
  }
}

