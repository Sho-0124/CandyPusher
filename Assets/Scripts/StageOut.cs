using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    private int Score;
    public TextMeshProUGUI scoreText;

    public AudioManager audioManager;
    void OnTriggerEnter(Collider other)
    {
        AudioManager.instance.SEPlay(0);

        Score += 1;
        scoreText.text = $"スコア：{Score}";
        //Debug.Log($"{other.name}がすり抜けた");
        Destroy(other.gameObject);
    }
}
