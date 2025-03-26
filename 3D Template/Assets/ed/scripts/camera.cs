using UnityEngine;

public class camera : MonoBehaviour
{
    public bool can_see_player = false;
    private GameObject player;
    public GameObject detection_visual;
    private ui ui;
    public GameObject actual_camera;

    public GameObject my_detection_visual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        ui = FindFirstObjectByType<ui>();
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
        if (my_detection_visual != null)
        {
            if (my_detection_visual.transform.rotation.z != Vector3.Angle(actual_camera.transform.position, player.transform.position))
            {
                my_detection_visual.transform.Rotate(0, 0, Vector3.Angle(actual_camera.transform.position, player.transform.position));
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            can_see_player = true;
            GameObject new_detection = Instantiate(detection_visual, ui.transform.position, Quaternion.identity);
            new_detection.transform.SetParent(ui.crosshair.transform);
            my_detection_visual = new_detection.gameObject;
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
