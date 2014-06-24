using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public float speed;
	public float jumpPower;

	private CharacterController cController;


	// Use this for initialization
	void Start () {
		Debug.Log("Cube!");
		cController = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 moveDirection = new Vector3(.1f, 0, 0);
		cController.Move(moveDirection);
		//Debug.Log("Cube!");

	}
}




