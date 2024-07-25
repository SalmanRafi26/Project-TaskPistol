using UnityEngine;

public class GameObjectLifeHandler : MonoBehaviour
{
    [SerializeField] private float life;
    
    private void Start()
    {
        Destroy(gameObject, life);
    }
}
