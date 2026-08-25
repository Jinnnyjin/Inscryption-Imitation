
public class CardInstance
{
    public CardData data;
    public int curAttack;
    public int curHealth;
    // 도장 : Sprinter(질주자) 이동방향
    public MoveDirection? sprinterCurDirection;

    public CardInstance(CardData data)
    {
        this.data = data;
        curAttack = data.attack;
        curHealth = data.health;
    }
}
