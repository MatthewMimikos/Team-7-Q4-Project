using UnityEngine;

public class SetGameUIInactive : MonoBehaviour
{
    public GameObject UI;
    public GameObject TitleScreen;
    public bool CheckStart = false;
    public PlayerCam playercamera;
    public PlayerMovement PlayerMovement;
    public MaskSwitching MaskSwitching;
    public gamemanager manager;

    public void Start()
    {
        if (!CheckStart)
        {
            UI.SetActive(false);
            TitleScreen.SetActive(true);
        }
    }

    public void TitleScreenEnd()
    {
        UI.SetActive(true);
        TitleScreen.SetActive(false);
        CheckStart = true;
        GameObject newUI = Instantiate(UI);
        manager.ui = newUI;
        playercamera.enabled = true;
        PlayerMovement.enabled = true;
        MaskSwitching.enabled = true;
        manager.begingame();
    }
}
