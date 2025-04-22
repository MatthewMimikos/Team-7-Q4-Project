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
