namespace Section03.Anti
{
  public class Warrior
  {
    private int hp;     // ヒットポイント
    private int power;  // 攻撃力

    public Warrior(int hp, int power)
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

    public void damage(int power)
    {
      hp -= power;
    }

    public void powerUp()
    {
      power *= 3;
    }
  }
}

