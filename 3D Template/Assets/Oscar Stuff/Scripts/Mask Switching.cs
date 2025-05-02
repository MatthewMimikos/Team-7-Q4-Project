using UnityEngine;
using UnityEngine.UI;

public class MaskSwitching : MonoBehaviour
{
    public int currentMask;
    public Texture2D No_mask;
    public Texture2D Miner_mask;
    public Texture2D Guard_mask;
    public Texture2D Camera_mask;
    public ui ui;
    private gamemanager gamemanager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ui = FindFirstObjectByType<ui>();
        gamemanager = FindFirstObjectByType<gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            ui.switch_mask(Miner_mask);
            gamemanager.switch_mask(1);
            currentMask = 1;
        }
        if (Input.GetKeyDown("2"))
        {
            ui.switch_mask(Guard_mask);
            gamemanager.switch_mask(2);
            currentMask = 2;
        }
        if (Input.GetKeyDown("3"))
        {
            ui.switch_mask(Camera_mask);
            gamemanager.switch_mask(3);
            currentMask = 3;
        }
        if (Input.GetKeyDown("4"))
        {
            ui.switch_mask(No_mask);
            gamemanager.switch_mask(4);
            currentMask = 0;
        }
    }
}
