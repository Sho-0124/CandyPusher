using UnityEngine;
using UnityEngine.InputSystem;

public class FloorController : MonoBehaviour
{
    public GameObject stage;

    private bool isStageActive = true;

    void Update()
    {
        // EnterƒL[‚ª‰Ÿ‚³‚ê‚½uŠÔ
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            isStageActive = !isStageActive;

            stage.SetActive(isStageActive);
        }
    }
}