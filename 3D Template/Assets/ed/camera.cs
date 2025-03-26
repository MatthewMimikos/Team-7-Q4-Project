using UnityEngine;

public class camera : MonoBehaviour
{
    public bool can_see_player = false;
    private GameObject player;
    public GameObject actual_camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (can_see_player)
        {
            if (Physics.Raycast(actual_camera.transform.position, player.transform.position - actual_camera.transform.position, out RaycastHit hitInfo, 50f))
            {
                Debug.Log(hitInfo.transform.gameObject.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (can_see_player)
        {
            Gizmos.DrawLine(actual_camera.transform.position, player.transform.position - actual_camera.transform.position * 50f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            can_see_player = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            can_see_player = false;
        }
    }
}
