using UnityEngine;

public class CandyTube : MonoBehaviour
{

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * 1f)*6f;
        this.transform.position = startPosition + new Vector3(x, 0, 0);
    }
}
