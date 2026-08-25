using UnityEngine;

/// <summary>
/// 도장: 질주자
/// </summary>
[CreateAssetMenu(fileName = "SprinterSigil", menuName = "Sigil/질주자")]
public class SprinterSigil : SigilBase, ITurnEndTrigger
{

    public void OnTurnEnd(BattleContext context)
    {

    }
}
