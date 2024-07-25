using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private bool isPistolSelected;

    [SerializeField] private GameObject Pistol;
    [SerializeField] private GameObject Shotgun;

    public WeaponShootInt CurrentWeapon;
    
    private void Update()
    {
        if (ControlFreak2.CF2Input.GetKey(KeyCode.R))
        {
            isPistolSelected = !isPistolSelected;
            SwitchWeapon();
        }
        if (ControlFreak2.CF2Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void SwitchWeapon()
    {
        if (isPistolSelected)
        {
            Pistol.SetActive(true);
            Shotgun.SetActive(false);
        }
        else
        {
            Pistol.SetActive(false);
            Shotgun.SetActive(true);
        }
    }
    void Shoot()
    {
        CurrentWeapon.OnShoot();
    }
}
