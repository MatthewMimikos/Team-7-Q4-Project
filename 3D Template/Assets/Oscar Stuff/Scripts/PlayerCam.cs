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
    public MaskSwitching MaskSwitcher;
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
        bool can_pickup_dynamite = false;

        GameObject item = null;

        if (HitInfo.collider.CompareTag("dropped_shovel"))
        {
            ui.info_text.text = "Shovel";
            ui.info_text2.text = "Press E to pick up";
            item = HitInfo.collider.gameObject;
            can_pickup_shovel = true;
            can_pickup_shotgun = false;
            can_pickup_dynamite = false;
        }
        else if (HitInfo.collider.CompareTag("dropped_shotgun"))
        {
            ui.info_text.text = "Shotgun";
            ui.info_text2.text = "Press E to pick up";
            item = HitInfo.collider.gameObject;
            can_pickup_shotgun = true;
            can_pickup_shovel = false;
            can_pickup_dynamite = false;
        }
        else if (HitInfo.collider.CompareTag("dynamite"))
        {
            ui.info_text.text = "Dynamite";
            ui.info_text2.text = "Press E to pick up";
            item = HitInfo.collider.gameObject;
            can_pickup_dynamite = true;
            can_pickup_shovel = false;
            can_pickup_shotgun = false;
        }
        else if (HitInfo.collider.CompareTag("shells"))
        {
            ui.info_text.text = "Shotgun Shells";
            ui.info_text2.text = "Press E to pick up";
            item = HitInfo.collider.gameObject;
            can_pickup_dynamite = true;
            can_pickup_shovel = false;
            can_pickup_shotgun = false;
        }
        else if (HitInfo.collider.GetComponent<pickup>().guard_mask)
        {
            ui.info_text.text = "Guard Mask";
            ui.info_text2.text = "Press E to pick up, opens guard doors while wearing";
            item = HitInfo.collider.gameObject;
        }
        else
        {
            ui.info_text.text = "";
            ui.info_text2.text = "";
            item = null;
            can_pickup_shovel = false;
            can_pickup_shotgun = false;
            can_pickup_dynamite = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (can_pickup_shovel == true)
            {
                GameObject.Find("WeaponHolder").GetComponent<WeaponSwitching>().has_shovel = true;
                gamemanager.GetComponent<gamemanager>().diologue("Picked up a Shovel. To switch weapons, use the scrollwheel or right click", false);
                ui.info_text.text = "";
                ui.info_text2.text = "";
            }
            if (can_pickup_shotgun == true)
            {
                GameObject.Find("WeaponHolder").GetComponent<WeaponSwitching>().has_shotgun = true;
                gamemanager.GetComponent<gamemanager>().diologue("Picked up a Shotgun. To switch weapons, use the scrollwheel or right click", false);
                ui.info_text.text = "";
                ui.info_text2.text = "";
            }
            if (can_pickup_dynamite == true)
            {
                gamemanager.GetComponent<gamemanager>().diologue("Picked up Dynamite, Press F to drop it and ingite it's fuse", false);
                ui.info_text.text = "";
                ui.info_text2.text = "";
            }
            if (item.GetComponent<pickup>().shell == true)
            {
                GameObject.Find("bullet_maker").GetComponent<bullet_create>().ammo += 4;
            }
            if (item.GetComponent<pickup>().guard_mask == true)
            {
                gamemanager.GetComponent<gamemanager>().diologue("Picked up a Guard Mask, Press 2 to wear it and be able to open doors", false);
                MaskSwitcher.has_guard_mask = true;
                ui.info_text.text = "";
                ui.info_text2.text = "";
            }
            if (HitInfo.collider.GetComponent<pickup>().guard_mask)
            {

            }
            if (item)
            {
                item.GetComponent<pickup>().picked_up();
            }
        }
    }
}