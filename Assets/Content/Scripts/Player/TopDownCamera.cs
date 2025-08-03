using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    [SerializeField] private Transform target; // Объект, за которым следует камера
    [SerializeField] private float height = 10f; // Высота камеры
    [SerializeField] private float smoothSpeed = 5f; // Плавность движения


    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = new Vector3(target.position.x, height, target.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}