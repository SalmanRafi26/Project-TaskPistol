using UnityEngine;

public class Pistol : MonoBehaviour, WeaponShootInt
{
    [SerializeField] PlayerControls PC;
    
    [SerializeField] private Transform ShootPoint;

    private void OnEnable()
    {
        PC.CurrentWeapon = this;
    }

    public void OnShoot()
    {
        GameObject bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = ShootPoint.position;
        bullet.transform.rotation = ShootPoint.rotation;
        bullet.GetComponent<BulletHandler>().OnActivateBullet();
    }
}
