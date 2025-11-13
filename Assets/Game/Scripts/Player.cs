using UnityEngine;

public class Player : MonoBehaviour
{
    private const string HORIZONTAL_AXIS_NAME = "Horizontal";
    private const string VERTICAL_AXIS_NAME = "Vertical";

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private float _deadZone = 0.05f;
    
    private Mover _transformHandler;

    private void Awake()
    {
        _transformHandler = new Mover(transform, _moveSpeed, _rotationSpeed);
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis(HORIZONTAL_AXIS_NAME), 0, Input.GetAxis(VERTICAL_AXIS_NAME));

        if(input.magnitude <= _deadZone)
            return;

        Vector3 normalizedInput = input.normalized;

        _transformHandler.ProcessMoveTo(normalizedInput);
        _transformHandler.ProcessRotateTo(normalizedInput);
    }
}
