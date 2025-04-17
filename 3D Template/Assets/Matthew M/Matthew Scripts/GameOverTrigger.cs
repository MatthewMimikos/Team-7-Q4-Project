using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{

    public bool Death;
    public GameObject DeathCanvas;
    public PlayerCam playercamera;
    public PlayerMovement PlayerMovement;

    public void CheckForDeath()
    {
        if (Death)
        {
            DeathCanvas.SetActive(true);
            playercamera.enabled = false;
            PlayerMovement.enabled = false;
        }
        else
        {
            DeathCanvas.SetActive(false);
        }
    }

    public void Start()
    {
        DeathCanvas.SetActive(false);
    }

    void Update()
    {
        CheckForDeath();
    }
}
