using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("Vector indicating the rotation axis (e.g., Vector3.up for Y-axis).")]
    public Vector3 rotationAxis = Vector3.up;

    [Tooltip("Rotation speed in degrees per second.")]
    public float rotationSpeed = 90f;

    [Tooltip("Choose whether to rotate relative to world space or local space.")]
    public Space rotationSpace = Space.Self;

    void Update()
    {
        // Rotate the object smoothly based on degrees per second
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, rotationSpace);
    }
}