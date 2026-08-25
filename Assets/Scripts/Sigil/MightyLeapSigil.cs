using UnityEngine;

/// <summary>
/// 도장: 위대한 도약
/// </summary>
[CreateAssetMenu(fileName = "MightyLeapSigil", menuName = "Sigil/위대한 도약")]
public class MightyLeapSigil : SigilBase, IBlockInteraction
{

    public bool TryBlock(BattleContext context)
    {
        bool isAttack = false;

        return isAttack;
    }
}
