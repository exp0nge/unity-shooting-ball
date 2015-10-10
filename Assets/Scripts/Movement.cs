using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 0.1F;
	public float gravity = -999.81F;
	private CharacterController charCtrl;
	//public float gravity = -20.5F;
	private Vector3 direction = Vector3.zero;

	// Use this for initialization
	void Start () {
		charCtrl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		move();
    }
	private void move() {
		transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
		direction = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * speed;
		charCtrl.Move(direction);
	}
}
