using UnityEngine;

public class SetGameUIInactive : MonoBehaviour
{
    public GameObject UI;
    public GameObject TitleScreen;
    public bool CheckStart = false;
    public PlayerCam playercamera;
    public PlayerMovement PlayerMovement;

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
        playercamera.enabled = true;
        PlayerMovement.enabled = true;
    }
}
