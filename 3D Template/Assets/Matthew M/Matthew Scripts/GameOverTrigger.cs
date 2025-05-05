using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{

    public bool Death;
    public GameObject DeathCanvas;
    public PlayerCam playercamera;
    public PlayerMovement PlayerMovement;
    public MaskSwitching MaskSwitching;

    public void CheckForDeath()
    {
        if (Death)
        {
            DeathCanvas.SetActive(true);
            playercamera.enabled = false;
            PlayerMovement.enabled = false;
            MaskSwitching.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            DeathCanvas.SetActive(false);
        }
    }

    public void Start()
    {
        DeathCanvas.SetActive(false);
        Death = false;
    }

    void Update()
    {
        CheckForDeath();
    }
}
