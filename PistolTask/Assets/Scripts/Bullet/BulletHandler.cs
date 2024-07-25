using UnityEngine;

public class BulletHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float Damage;

    [SerializeField] private float bulletSpeed;

    public void OnActivateBullet()
    {
        rb.velocity = transform.right * bulletSpeed;
        
        ReturnToPoolIfNoCollision();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ReturnToPool();
    }
    private void ReturnToPool()
    {
        BulletPool.Instance.ReturnBullet(gameObject);
    }
    private void ReturnToPoolIfNoCollision()
    {
        Invoke("ReturnToPool", 2f);
    }
}
