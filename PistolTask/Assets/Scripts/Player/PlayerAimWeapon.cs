using UnityEngine;

public class PlayerAimWeapon : MonoBehaviour
{
    [SerializeField] Transform aimTransform;

    private void Update()
    {
        Transform nearestTarget = GamePlayHandler.instance.GetNearestObstacle();
        if (nearestTarget != null)
        {
            Vector3 mousePosition = nearestTarget.position;
            Vector3 aimDirection = (mousePosition - transform.position).normalized;
            float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
            aimTransform.eulerAngles = new Vector3(0, 0, angle);
        }
        else
        {
            aimTransform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
