
using System;
using static UnityEngine.Rendering.DebugUI.Table;

/// <summary>
/// 스테이지(전투)에 활용되는 보드판
/// </summary>
public class Board
{
    // Board 배열판 3줄
    public CardInstance[] previewRow = new CardInstance[4];
    public CardInstance[] monsterRow = new CardInstance[4];
    public CardInstance[] playerRow = new CardInstance[4];



    /// <summary>
    /// 지정된 보드 위치에 해당하는 카드 인스턴스를 확인
    /// </summary>
    /// <param name="pos">조회할 보드 위치 (row , index) / 
    /// row = ( preview, monster, player) / 
    /// index = 0~3</param>
    /// <returns>해당 위치의 CardInstance. 카드가 없으면 null</returns>
    public CardInstance GetCard(BoardPosition pos)
    {
        return GetRowArray(pos.row)[pos.index];
    }


    /// <summary>
    /// 지정된 보드 위치에 해당하는 카드 인스턴스를 배치
    /// </summary>
    /// <param name="pos">조회할 보드 위치 (row , index) / 
    /// row = ( preview, monster, player) / 
    /// index = 0~3</param>
    /// <param name="card">놓을 카드인스턴스</param>
    public void PlaceCard(BoardPosition pos, CardInstance card)
    {
        if(!IsEmpty(pos))
            throw new System.InvalidOperationException($"{pos.row}열 {pos.index}칸에 이미 카드가 있습니다.");
        
        GetRowArray(pos.row)[pos.index] = card;
    }

    /// <summary>
    /// 지정된 보드 위치에 해당하는 카드 인스턴스를 제거
    /// </summary>
    /// <param name="pos">조회할 보드 위치 (row , index) / 
    /// row = ( preview, monster, player) / 
    /// index = 0~3</param>
    /// <param name="card">놓을 카드인스턴스</param>
    public void RemoveCard(BoardPosition pos)
    {
        if (IsEmpty(pos))
            throw new System.InvalidOperationException($"{pos.row}열 {pos.index}칸은 이미 비어 있습니다.");

        GetRowArray(pos.row)[pos.index] = null;
    }

    /// <summary>
    /// 지정된 보드 위치가 비어있는지 확인
    /// </summary>
    /// <param name="pos">name="pos">조회할 보드 위치 (row , index) / 
    /// row = ( preview, monster, player) / 
    /// index = 0~3</param>
    /// <returns>비어있다면 true, 카드가 있다면 false</returns>
    public bool IsEmpty(BoardPosition pos)
    {
        return GetCard(pos) == null;
    }


    /// <summary>
    /// BoardRow 값에 해당하는 실제 배열을 반환.
    /// GetCard/SetCard가 각자 매핑 로직을 중복하지 않도록 이 메서드로 일원화.
    /// </summary>
    /// <param name="row">조회할 보드 열</param>
    /// <returns>해당 열의 CardInstance 배열</returns>
    /// <exception cref="System.ArgumentException">정의되지 않은 BoardRow 값이 들어온 경우</exception>
    private CardInstance[] GetRowArray(BoardRow row)
    {
        switch(row)
        {
            case BoardRow.Preview:
                return previewRow;
            case BoardRow.Monster:
                return monsterRow;
            case BoardRow.Player:
                return playerRow;
            default:
                throw new System.ArgumentException($"Unknown row: {row}");

        }
    }
}
