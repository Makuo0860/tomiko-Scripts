using UnityEngine;

public class 鳥こっちみる : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private Transform target;

    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private float downAngle = 5f;

    void LateUpdate()
    {
        if (head == null || target == null) return;

        Vector3 direction = target.position - head.position;

        if (direction.sqrMagnitude < 0.001f) return;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        targetRotation *= Quaternion.Euler(downAngle, 0f, 0f);

        head.rotation = Quaternion.Slerp(
            head.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}