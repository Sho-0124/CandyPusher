using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    private int Score;
    public TextMeshProUGUI scoreText;
    void OnTriggerEnter(Collider other)
    {
        Score = Score + 1;
        scoreText.text = $"スコア：{Score}";
        //Debug.Log($"{other.name}がすり抜けた");
        Destroy(other.gameObject);
    }
}
