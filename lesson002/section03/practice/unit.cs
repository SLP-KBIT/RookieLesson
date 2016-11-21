namespace Section03.Practice
{
  abstract public class Unit
  {
    protected int hp;     // ヒットポイント
    protected int power;  // 攻撃力

    public Unit(int hp, int power)
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

    abstract public void powerUp();
  }
}

