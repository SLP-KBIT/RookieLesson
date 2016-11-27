namespace Section02.Anti
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

      s2.hp -= s1.power; // s1がs2に攻撃
      s1.hp -= s2.power; // s2がs1に攻撃

      WriteResult(s1, s2);
    }

    public static void WriteResult(Soldier s1, Soldier s2)
    {
      // 値の出力
      Console.WriteLine("---s1---");
      Console.WriteLine("hp : " + s1.hp + ", power : " + s1.power);
      Console.WriteLine("---s2---");
      Console.WriteLine("hp : " + s2.hp + ", power : " + s2.power);
    }
  }
}

