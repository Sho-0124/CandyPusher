using UnityEngine;

public class Pusher : MonoBehaviour
{
    //アクセス修飾子
    public float speed = 1f;
    public float movePower = 5f;
    private Vector3 startPosition;
    private Rigidbody rb;
    int pusherMoveRange = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.position;
        Debug.Log("ゲームが開始した");
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * pusherMoveRange;
        Debug.Log(z);
        //this.transform.localPosition = startPosition + new Vector3(0, 0, z);
        rb.linearVelocity = new Vector3(0, 0, z);
    }
}
