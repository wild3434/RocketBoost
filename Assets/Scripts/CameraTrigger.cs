using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Transform cameraTarget; // Assign in Inspector
    public float moveSpeed = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.main.transform.position = Vector3.Lerp(
                Camera.main.transform.position,
                cameraTarget.position,
                moveSpeed * Time.deltaTime
            );
        }
    }
}