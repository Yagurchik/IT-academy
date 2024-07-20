using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputActions _input;
    private float _moveSpeed = 10f;
    [SerializeField] private Transform firePoint;
    public Bullet _bullet;

    private float currentRotationAngle = 0f;

    private void Awake()
    {
        _input = new InputActions();

        _input.Gameplay.Shoot.performed += context => Shoot();
        _input.Gameplay.Shoot.Enable();
    }
    private void OnEnable()
    {
        if (_input != null)
        {
            _input = new InputActions();
        }
        _input.Gameplay.Jump.started += Jump_started;
        _input.Enable();
    }
    private void OnDisable()
    {
        if (_input != null)
        {
            return;
        }
        _input.Gameplay.Jump.started -= Jump_started;
        _input.Gameplay.Shoot.performed -= context => Shoot();
        _input.Disable();
    }
    private void Jump_started(InputAction.CallbackContext ctx)
    {

    }
    private void Update()
    {
        Vector2 moveDirection = _input.Gameplay.Movement.ReadValue<Vector2>();
        float _rotationX = _input.Gameplay.MouseRotation.ReadValue<float>();
        
        Move(moveDirection);
        Rotation(_rotationX);
    }
    private void Move(Vector2 direction)
    {
        float scaledMoveSpeed = _moveSpeed * Time.deltaTime;

        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaledMoveSpeed;
    }
    private void Shoot()
    {
        if(_bullet == null)
        {
            Debug.Log("Button is null!");
            return;
        }
        Debug.Log("Bah");
        Bullet bullet = Instantiate(_bullet, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * 100f;
    }
    private void Rotation(float axis) 
    {
        //currentRotationAngle += axis;
        //currentRotationAngle = Mathf.Clamp(currentRotationAngle, -5.0f, 5.0f);
        transform.Rotate(Vector3.up, axis);
    }
}
