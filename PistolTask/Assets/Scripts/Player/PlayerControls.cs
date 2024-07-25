using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private GameObject Pistol;
    [SerializeField] private GameObject Shotgun;

    public WeaponShootInt CurrentWeapon;

    [SerializeField] private Transform PlayerRadiusDetector;
    
    private void Update()
    {
        PlayerRadiusDetector.localScale = new Vector3(GamePlayHandler.instance.PlayerRadius, 
            GamePlayHandler.instance.PlayerRadius, 
            GamePlayHandler.instance.PlayerRadius);
        if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.R))
        {
            SwitchWeaponToPistol();
        }
        if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.T))
        {
            SwitchWeaponToShotgun();
        }
        if (ControlFreak2.CF2Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void SwitchWeaponToPistol()
    {
        Pistol.SetActive(true);
        Shotgun.SetActive(false);
    }
    private void SwitchWeaponToShotgun()
    {
        Pistol.SetActive(false);
        Shotgun.SetActive(true);
    }
    void Shoot()
    {
        CurrentWeapon.OnShoot();
    }
}
