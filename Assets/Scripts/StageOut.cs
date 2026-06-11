using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    private int Score;
    void OnTriggerEnter(Collider other)
    {
        Score = Score + 1;
        Debug.Log($"スコア：{Score}");
        //Debug.Log($"{other.name}がすり抜けた");
        Destroy(other.gameObject);
    }
}
