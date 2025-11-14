using UnityEngine;

public class Mover
{
    private float _moveSpeed;
    private float _rotationSpeed;

    private Transform _charachterTransform;

    public Mover(Transform charachterTransform, float moveSpeed, float rotationSpeed)
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

    public void ChangeMoveSpeed(float value)
    {
        _moveSpeed += value;

        if(_moveSpeed < 0)
            _moveSpeed = 0;

        Debug.Log("Текущая скорость: " + _moveSpeed);
    }
}
