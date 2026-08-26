
/// <summary>
/// 전투에 사용되는 배열판 클래스
/// </summary>
public class Board
{
    // 배열 row값을 Enum으로 관리
    public enum BoardRow { Preview, Monster, Player };

    // Board 배열판 3줄
    public CardInstance[] previewRow = new CardInstance[4];
    public CardInstance[] monsterRow = new CardInstance[4];
    public CardInstance[] playerRow = new CardInstance[4];

    // 해당 배열 카드 가져오기
    public CardInstance GetCard(BoardRow row, int index)
    {
        CardInstance[] target = GetRowArray(row);
        return target[index];
    }

    // 배열에 카드 설정
    public void SetCard(BoardRow row, int index, CardInstance card)
    {
        CardInstance[] target = GetRowArray(row);
        target[index] = card;
    }

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
