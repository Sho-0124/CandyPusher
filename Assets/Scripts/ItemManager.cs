using UnityEngine;
using TMPro;

public class ItemManager : MonoBehaviour
{
    public int grapeCount = 0;
    public int orangeCount = 0;
    public int melonCount = 0;
    public int colaCount = 0;
    public int sodaCount = 0;

    public TMP_Text itemCountText;

    private void Start()
    {
        UpdateUI();
    }

    public void GetItem(string itemName)
    {
        if (itemName == "ぶどう味")
        {
            grapeCount++;
        }
        else if (itemName == "みかん味")
        {
            orangeCount++;
        }
        else if (itemName == "メロン味")
        {
            melonCount++;
        }
        else if (itemName == "コーラ味")
        {
            colaCount++;
        }
        else if (itemName == "ソーダ味")
        {
            sodaCount++;
        }

        Debug.Log(itemName + "をGET！");

        UpdateUI();
    }

    private void UpdateUI()
    {
        itemCountText.text =
            "ぶどう味：" + grapeCount + "\n" +
            "みかん味：" + orangeCount + "\n" +
            "メロン味：" + melonCount + "\n" +
            "コーラ味：" + colaCount + "\n" +
            "ソーダ味：" + sodaCount;
    }
}
