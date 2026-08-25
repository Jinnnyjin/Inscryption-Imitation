using UnityEngine;

[CreateAssetMenu(fileName ="Card_", menuName = "Card/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public int attack;
    public int health;
    public Cost cost;
    public SigilBase Sigil;
    public CardType type;
    public Sprite artwork;
    public string description;

}
