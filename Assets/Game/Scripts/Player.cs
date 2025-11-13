using UnityEngine;

public class Player : MonoBehaviour
{
    private const string HORIZONTAL_AXIS_NAME = "Horizontal";
    private const string VERTICAL_AXIS_NAME = "Vertical";
    
    private float _horizontalInput;
    private float _verticalInput;
    private const float _deadZone = 0.05f;
    
    [SerializeField] private float _moveSpeed;

    private void Update() 
    {
        _horizontalInput = Input.GetAxis(HORIZONTAL_AXIS_NAME);
        _verticalInput = Input.GetAxis(VERTICAL_AXIS_NAME);

        if(Mathf.Abs(_horizontalInput) > _deadZone || Mathf.Abs(_verticalInput) > _deadZone)
        {
            Vector3 normalizedDirection = new Vector3(_horizontalInput, 0, _verticalInput).normalized;
            transform.position += normalizedDirection * _moveSpeed * Time.deltaTime;
        }
    }
}