using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    private int CandyCount = 0;
    public GameObject CandyPrefab;

    void AddCandy()
    {
        CandyCount = CandyCount + 1;
        Debug.Log(CandyCount);
        GameObject createPrefab = Instantiate(CandyPrefab);
        createPrefab.transform.position = this.transform.position;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AddCandy();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
    }
}
