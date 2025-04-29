using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    public int target = 120;

    private GameObject gamemanager;
    public bullet_create bullet_Create;
    public ui ui;
    public Vector3 raycast_point;

    public LayerMask layerMask;

    private void Awake()
    {
        Application.targetFrameRate = target;
    }

    private void Start()
    {
        ui = FindFirstObjectByType<ui>();
        gamemanager = GameObject.Find("gamemanager");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        Physics.Raycast(transform.position, transform.forward, out RaycastHit HitInfo, 100000f, layerMask);
        raycast_point = HitInfo.point;

        bool can_pickup_shovel = false;
        bool can_pickup_shotgun = false;

        GameObject item = null;

        if (HitInfo.collider.CompareTag("camera"))
        {
            ui.info_text.text = "Security Camera";
            ui.info_text2.text = "Damage with weapon to disable";
        }
        else if (HitInfo.collider.CompareTag("dropped_shovel"))
        {
            ui.info_text.text = "Shovel";
            ui.info_text2.text = "Press E to pick up";
            item = HitInfo.collider.gameObject;
            can_pickup_shovel = true;
        }
        else if (HitInfo.collider.CompareTag("dropped_shotgun"))
        {
            ui.info_text.text = "Shotgun";
            ui.info_text2.text = "Press E to pick up";
            item = HitInfo.collider.gameObject;
            can_pickup_shotgun = true;
        }
        else
        {
            ui.info_text.text = "";
            ui.info_text2.text = "";
            item = null;
            can_pickup_shovel = false;
            can_pickup_shotgun = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (can_pickup_shovel == true)
            {
                GameObject.Find("WeaponHolder").GetComponent<WeaponSwitching>().has_shovel = true;
                gamemanager.GetComponent<gamemanager>().diologue("Picked up a Shovel. To switch weapons, use the scrollwheel or right click", false);
            }
            if (can_pickup_shotgun == true)
            {
                GameObject.Find("WeaponHolder").GetComponent<WeaponSwitching>().has_shotgun = true;
                gamemanager.GetComponent<gamemanager>().diologue("Picked up a Shotgun. To switch weapons, use the scrollwheel or right click", false);
            }
            if (item)
            {
                Destroy(item.gameObject);
            }
        }
    }
}