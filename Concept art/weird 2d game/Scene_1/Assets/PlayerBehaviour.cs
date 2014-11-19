using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{

		private Vector2 direction;
		private float speed = 1.0f;
		private bool isWalking = false;
		private bool walkRight = false;
		private bool walkLeft = false;
		private Vector3 endPosition = Vector3.zero;
		private float duration = 1.0f;
		private Animator anim;

		void Start ()
		{
				anim = this.GetComponent ("Animator") as Animator;
				print (transform.position);
		}
	
		void Update ()
		{			
				if (Input.GetMouseButton (0)) {
						RaycastHit hit;
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						if (Physics.Raycast (ray, out hit)) {
								endPosition = hit.point;
								//endPosition = transform.position;
								//endPosition.x = Input.mousePosition.x;
								print (endPosition);
								float endX = endPosition.x;
								isWalking = true;
								if (endX > transform.position.x) {
										anim.SetTrigger ("walkingRight");
								} else {
										anim.SetTrigger ("walkingLeft");
								}

								if (isWalking) {
										transform.position = Vector3.Lerp (transform.position, endPosition, (Time.time * speed) / duration);

								} else {
										anim.SetTrigger ("idle");
								}
						}
				}
				if (Mathf.Approximately (transform.position.x, endPosition.x)) {
						isWalking = false;

				}
	
		}
}	
