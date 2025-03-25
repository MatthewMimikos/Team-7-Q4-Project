using UnityEngine;

public class LoreNoteMenu : MonoBehaviour
{
    public GameObject LoreMenu;

    public void Start()
    {
        LoreMenu.SetActive(false);
    }

    public void OpenLoreNoteMenu()
    {
        LoreMenu.SetActive(true);
    }
}
