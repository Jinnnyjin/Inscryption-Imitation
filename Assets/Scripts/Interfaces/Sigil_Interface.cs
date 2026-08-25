
/// <summary>
/// 공격 방식 변경
/// ex) 이분공격, 공수
/// </summary>
public interface IAttackerModifier
{
    void OnAttack(BattleContext context);

}

/// <summary>
/// 패시브
/// ex) 구린내
/// </summary>
public interface IPassiveModifier
{
    void OnModifyPower(BattleContext context);
}

/// <summary>
/// 턴 종료 트리거
/// ex) 질주자
/// </summary>
public interface ITurnEndTrigger
{
    void OnTurnEnd(BattleContext context);
}

/// <summary>
///  방어 상호작용
///  ex) 위대한 도약
/// </summary>
public interface IBlockInteraction
{
    bool TryBlock(BattleContext context);
}
