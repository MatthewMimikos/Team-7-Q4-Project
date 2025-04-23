using Unity.VisualScripting;
using UnityEngine;

public class breakablewindow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void wow()
    {
        Debug.Log("broke_window");
        GetComponent<BoxCollider>().enabled = false;
        foreach (Transform child in this.transform)
        {
            child.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            child.gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f)));
            child.gameObject.transform.Rotate(new Vector3(Random.Range(-360f, 360f), Random.Range(-360f, 360f), Random.Range(-360f, 360f)));
        }
        while (this.transform.childCount > 0)
        {
            this.transform.GetChild(0).SetParent(null);
        }
    }
}
