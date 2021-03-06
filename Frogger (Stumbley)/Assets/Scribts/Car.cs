using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	public float speed;

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}
