using UnityEngine;

public class 鳥こっちみる : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private Transform target;

    [SerializeField] private float rotationSpeed = 5f;

    // 下向き補正角度
    [SerializeField] private float downAngle = 5f;

    void LateUpdate()
    {
        if (head == null || target == null) return;

        // 頭からターゲットへの方向
        Vector3 direction = target.position - head.position;

        if (direction.sqrMagnitude < 0.001f) return;

        // ターゲット方向を向く
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // 少し下を向くように補正
        targetRotation *= Quaternion.Euler(downAngle, 0f, 0f);

        // なめらかに回転
        head.rotation = Quaternion.Slerp(
            head.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}