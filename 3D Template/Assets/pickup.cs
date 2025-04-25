using UnityEngine;

public class pickup : MonoBehaviour
{
    public bool pickable = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pickable == true)
        {
            Destroy(gameObject);
        }
    }
}
