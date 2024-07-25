using System;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField] private GameObject ImpactParticle;
    
    private void Start()
    {
        GamePlayHandler.instance.AddObstacle(transform);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent<BulletHandler>(out BulletHandler BH))
        {
            ContactPoint2D contact = other.contacts[0];
            Instantiate(ImpactParticle, contact.point, Quaternion.identity);
        }        
    }
}
