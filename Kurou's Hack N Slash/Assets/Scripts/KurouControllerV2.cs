using UnityEngine;
using System.Collections;

public class KurouControllerV2 : MonoBehaviour {

	public float jump_force = 10.0f;
	public float ground_dist = 0.2f;
	public float move_force = 10.0f;
	
	private Rigidbody2D rb;
	
	void Awake() {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update() {
		RaycastHit2D hit =
			Physics2D.Raycast(
				new Vector2(transform.position.x, transform.position.y),
				-Vector2.up,
				ground_dist
				);
		
		if (hit.collider != null && Input.GetAxis("Vertical") > 0)
			rb.AddForce(Vector2.up * jump_force);
		
		rb.AddForce(Input.GetAxis("Horizontal") * Vector2.right * move_force);
	}
}
