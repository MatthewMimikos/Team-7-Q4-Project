using UnityEngine;

public class LoreNoteReading : MonoBehaviour
{
    public GameObject LoreMenu;
    public GameObject LoreReading;

    public void Start()
    {
        LoreReading.SetActive(false);
    }
    public void OpenLore()
    {
        LoreMenu.SetActive(false);
        LoreReading.SetActive(true);
    }

    public void CloseLore()
    {
        LoreMenu.SetActive(true);
        LoreReading.SetActive(false);
    }
}
