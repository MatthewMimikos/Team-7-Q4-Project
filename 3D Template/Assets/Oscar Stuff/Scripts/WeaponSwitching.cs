using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;
    public bool has_shovel = false;
    public bool has_shotgun = false;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon == 0)
            {
                if (has_shotgun)
                {
                    selectedWeapon = 2;
                }
                else if (has_shotgun)
                {
                    selectedWeapon = 1;
                }
            }
            else if (selectedWeapon == 1)
            {
                selectedWeapon = 0;
            }
            else if (selectedWeapon == 2)
            {
                if (has_shovel)
                {
                    selectedWeapon = 1;
                }
                else if (has_shotgun)
                {
                    selectedWeapon = 0;
                }
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f || Input.GetMouseButtonDown(1)) 
        {
            if (selectedWeapon == 0)
            {
                if (has_shovel)
                {
                    selectedWeapon = 1;
                }
                else if (has_shotgun)
                {
                    selectedWeapon = 2;
                }
            }
            else if (selectedWeapon == 1)
            {
                if (has_shotgun)
                {
                    selectedWeapon = 2;
                }
                else if (has_shovel)
                {
                    selectedWeapon = 0;
                }
            }
            else if (selectedWeapon == 2)
            {
                selectedWeapon = 0;
            }
        }
        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("shoot");
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
                i++;
        }
    }
}
