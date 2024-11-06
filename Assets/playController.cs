using UnityEngine;
using UnityEngine.InputSystem;

public class playController : MonoBehaviour
{
  private Rigidbody rb;
  private float movementX;
  private float movementY;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public float speed = 10.0f;
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnMove(InputValue movementValue)
  {
    Vector2 movementVector = movementValue.Get<Vector2>();
    // rb.AddForce(movementVector);
    movementX = movementVector.x;
    movementY = movementVector.y;
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    rb.AddForce(movement * speed);
  }

  private void FixedUpdate()
  {

  }
}
