using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    private int CandyCount = 0;
    public GameObject CandyPrefab;
    public GameObject[] CandyPrefabs;

    float time = 0f;

    public AudioManager audioManager;

    public void AddCandy()
    {
        AudioManager.instance.SEPlay(1);

        CandyCount = CandyCount + 1;
        Debug.Log(CandyCount);
        int rand = Random.Range(0, 100);
        int CandyType = 0;

        if(rand < 50)
        {
            CandyType = 0;
        }

        else if(rand < 60)
        {
            CandyType = 1;
        }

        else if(rand < 70)
        {
            CandyType = 2;
        }

        else if(rand < 80)
        {
            CandyType = 3;
        }

        else if(rand < 99)
        {
            CandyType = 4;
        }

        GameObject createPrefab = Instantiate(CandyPrefabs[CandyType]);
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
        time += Time.deltaTime;
        if (time >= 1f)
        {
            AddCandy();
            time -= 1f;
        }
        // if•¶ ‚à‚µ‚àiğŒj‚ªtrue‚È‚ç‚Î{ }‚Ìˆ—‚ğ‚·‚é
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
    }
}
