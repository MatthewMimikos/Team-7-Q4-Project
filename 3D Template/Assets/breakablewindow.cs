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
        foreach (Transform child in this.transform)
        {
            child.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
