using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    [SerializeField] private Transform target; // ������, �� ������� ������� ������
    [SerializeField] private float height = 10f; // ������ ������
    [SerializeField] private float smoothSpeed = 5f; // ��������� ��������


    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = new Vector3(target.position.x, height, target.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}