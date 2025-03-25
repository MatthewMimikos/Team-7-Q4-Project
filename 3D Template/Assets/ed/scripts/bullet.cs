using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 120 * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit " + other);
        if (other.gameObject.GetComponent<enemy>())
        {
            Debug.Log("actually hit enemy");
            other.gameObject.GetComponent<enemy>().health -= 0;
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 3f);
    }
}
