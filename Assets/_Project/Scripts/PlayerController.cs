using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private CharacterController _characterController;
    
    private Vector2 _moveInput;
    
    [Header("Movement")]
    [SerializeField] private float walkSpeed;
    [SerializeField] private float verticalVelocity;
    
    [Header("Gravity")]
    [SerializeField] private float gravity;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void Update()
    {
        
    }
    
}
