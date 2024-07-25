using UnityEngine;

public class Shotgun : MonoBehaviour, WeaponShootInt
{
    [SerializeField] PlayerControls PC;
    
    [SerializeField] private Transform ShootPoint;
    
    public float SpreadAngle = 30f;
    public float ShotCount = 5;
    
    private void OnEnable()
    {
        PC.CurrentWeapon = this;
    }
    public void OnShoot()
    {
        float angleStep = SpreadAngle / (ShotCount - 1);
        float angle = -SpreadAngle / 2;

        for (int i = 0; i < ShotCount; i++)
        {
            Quaternion bulletRotation = ShootPoint.rotation * Quaternion.Euler(0, 0, angle);
            FireBullet(bulletRotation);
            angle += angleStep;
        }
    }
    void FireBullet(Quaternion rotation)
    {
        GameObject bullet = BulletPool.Instance.GetBullet();
        bullet.transform.position = ShootPoint.position;
        bullet.transform.rotation = rotation;
        bullet.GetComponent<BulletHandler>().OnActivateBullet();
    }
}
