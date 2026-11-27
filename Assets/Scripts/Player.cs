using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputAction _inputMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inputMove = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        var inputValue = _inputMove.ReadValue<Vector2>();
        var direction = new Vector3(inputValue.x, 0, 0).normalized * 0.1f;
        this.transform.Translate(direction, Space.World);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Vector3 ballv = Vector3.Normalize(collision.gameObject.transform.position - this.gameObject.transform.position);
            collision.rigidbody.linearVelocity = ballv * 20;
        }
    }
}
