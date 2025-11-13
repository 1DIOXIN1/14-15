using UnityEngine;

public class Mover
{
    private float _moveSpeed;
    private float _rotationSpeed;

    private Transform _charachterTransform;

    public Mover(Transform charachterTransform, float moveSpeed = 2f, float rotationSpeed = 600f)
    {
        _charachterTransform = charachterTransform;
        _moveSpeed = moveSpeed;
        _rotationSpeed = rotationSpeed;
    }

    public void ProcessMoveTo(Vector3 direction)
    {
        Vector3 movement = direction * _moveSpeed * Time.deltaTime;

        _charachterTransform.position += movement;
    }

    public void ProcessRotateTo(Vector3 direction)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        float step = _rotationSpeed * Time.deltaTime;

        _charachterTransform.rotation = Quaternion.RotateTowards(_charachterTransform.rotation, lookRotation, step);
    }
}
