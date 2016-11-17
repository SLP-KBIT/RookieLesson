namespace Section02
{
  public class Soldier
  {
    public int hp;     // ヒットポイント
    public int power;  // 攻撃力

    public Soldier(int hp, int power)
    {
      this.hp = hp;
      this.power = power;
    }

    public int getHp()
    {
      return hp;
    }

    public int getPower()
    {
      return power;
    }
  }
}

