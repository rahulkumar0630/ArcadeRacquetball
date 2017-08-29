using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Additionalforce : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter( Collision col ) {

		foreach (ContactPoint contact in col.contacts) {
			if( contact.thisCollider == GetComponent<Collider>() ) {
				// This is the paddle's contact point
				float english = contact.point.x - transform.position.x;

				contact.otherCollider.GetComponent<Rigidbody>().AddForce(25f * english, 0, 0);

			}


		}
	}
}

