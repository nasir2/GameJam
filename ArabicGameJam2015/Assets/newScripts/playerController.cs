using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpHeight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//playerController controller = GetComponent<playerController> ();
		//if (controller.isGrounded)
		//	print ("We are grounded, yeah man");

		if (Input.GetKey (KeyCode.Space)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
			
		}
		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
			
		}
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
			
		}
	}
}