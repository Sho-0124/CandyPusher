using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    // アイテムの所持数
    public int grapeCount = 0;
    public int orangeCount = 0;
    public int melonCount = 0;
    public int colaCount = 0;
    public int sodaCount = 0;

    // 合計スコア
    public int totalScore = 0;

    // UI
    public TMP_Text itemCountText;
    public TMP_Text scoreText;

    private void Start()
    {
        UpdateUI();
    }

    // アイテムを取得したときに呼ばれる
    public void GetItem(string itemName)
    {
        if (itemName == "ぶどう味")
        {
            grapeCount++;
            totalScore += 1;
        }
        else if (itemName == "みかん味")
        {
            orangeCount++;
            totalScore += 2;
        }
        else if (itemName == "キウイ味")
        {
            melonCount++;
            totalScore += 3;
        }
        else if (itemName == "コーラ味")
        {
            colaCount++;
            totalScore += 4;
        }
        else if (itemName == "ソーダ味")
        {
            sodaCount++;
            totalScore += 5;
        }

        UpdateUI();
    }

    // 画面表示を更新
    private void UpdateUI()
    {
        itemCountText.text =
            "ぶどう味：" + grapeCount + "\n" +
            "みかん味：" + orangeCount + "\n" +
            "キウイ味：" + melonCount + "\n" +
            "コーラ味：" + colaCount + "\n" +
            "ソーダ味：" + sodaCount;

        // スコアを「スコア：0」の形式で表示
        scoreText.text = "スコア：" + totalScore;
    }
}