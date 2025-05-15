using UnityEngine;

public class LoreNoteMenu : MonoBehaviour
{
    public GameObject LoreMenu;
    public GameObject RegularMenu;

    public void Start()
    {
        LoreMenu.SetActive(false);
    }

    public void OpenLoreNoteMenu()
    {
        LoreMenu.SetActive(true);
        RegularMenu.SetActive(false);
    }

    public void CloseLoreNoteMenu()
    {
        LoreMenu.SetActive(false);
        RegularMenu.SetActive(true);
    }
}
