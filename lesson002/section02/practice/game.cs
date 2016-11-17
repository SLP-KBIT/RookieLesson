namespace Section02.Practice
{
  using System;

  public class Game
  {
    public static void Main()
    {
      // Soldierをインスタンス化
      Soldier s1 = new Soldier(100, 30);
      Soldier s2 = new Soldier(200, 10);

      WriteResult(s1, s2);

      s1.damage(s2.getPower()); // s1がs2に攻撃
      s2.damage(s1.getPower()); // s2がs1に攻撃
      WriteResult(s1, s2);

      // 特殊攻撃(体力が半分になるかわりに攻撃力2倍)
      s2.damage(s1.specialAttack());
      WriteResult(s1, s2);
    }

    public static void WriteResult(Soldier s1, Soldier s2)
    {
      // 値の出力
      Console.WriteLine("---s1---");
      Console.WriteLine("hp : " + s1.getHp() + ", power : " + s1.getPower());
      Console.WriteLine("---s2---");
      Console.WriteLine("hp : " + s2.getHp() + ", power : " + s2.getPower());
    }
  }
}

