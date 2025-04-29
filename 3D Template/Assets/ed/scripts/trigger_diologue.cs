using UnityEngine;

public class trigger_diologue : MonoBehaviour
{

    private GameObject gamemanager;
    public string diologue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamemanager = GameObject.Find("gamemanager");
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gamemanager.GetComponent<gamemanager>().diologue(diologue, true);
            Destroy(gameObject);
        }
    }
}
