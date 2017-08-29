using UnityEngine;
using System.Collections;

public class paddlemovement : MonoBehaviour 
{

	public int speed = 10;
	public Rigidbody rb;
	public Vector2 xCon;
	public Vector2 yCon;
	Vector2 wantaBePos;


	void Update() { 

		//wantaBePos += new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		//transform.position = new Vector3(Mathf.Clamp(wantaBePos.x, xCon.x, xCon.y), Mathf.Clamp(wantaBePos.y, yCon.x, yCon.y), transform.position.z);


		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.down * speed * Time.deltaTime);
		}

			if (Input.touchCount == 1) {
				var touch = Input.touches [0];
				if (touch.position.x < Screen.width / 2 ) {
					transform.Translate (Vector3.up * speed * Time.deltaTime);
				} else if (touch.position.x > Screen.width / 2) {
					transform.Translate (Vector3.down * speed * Time.deltaTime);
				}
				
			}
		float xMove = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		transform.Translate(0f, xMove, 0f);
		Vector3 clampedPosition = transform.position;
		clampedPosition.x = Mathf.Clamp(transform.position.x, -3.78f, 3.78f);
		transform.position = clampedPosition;



		}



		



}
