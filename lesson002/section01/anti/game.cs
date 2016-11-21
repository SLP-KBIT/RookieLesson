namespace Section01.Anti
{
  using System;

  public class Game
  {
    public static void Main()
    {
      int hp1 = 100, power1 = 30;
      int hp2 = 200, power2 = 10;

      WriteResult(hp1, power1, hp2, power2);

      hp2 -= power1; // s1がs2に攻撃
      hp1 -= power2; // s2がs1に攻撃

      WriteResult(hp1, power1, hp2, power2);
    }

    public static void WriteResult(int hp1, int power1, int hp2, int power2)
    {
      // 値の出力
      Console.WriteLine("---s1---");
      Console.WriteLine("hp : " + hp1 + ", power : " + power1);
      Console.WriteLine("---s2---");
      Console.WriteLine("hp : " + hp2 + ", power : " + power2);
    }
  }
}

