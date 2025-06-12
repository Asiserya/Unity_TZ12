using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTrasform;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - playerTrasform.position;
    }

    private void FixedUpdate()
    {
        transform.position = playerTrasform.position + offset;
    }
}
