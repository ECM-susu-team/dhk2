using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	private float speed = 0f;
	private float JumpForce = 0f;
	private bool FaceToRight = true;
	private bool IsGround = false;
    GameObject WarriorClass;
    Warrior wrr;

    private Rigidbody2D RB;

	void Awake(){
		RB = GetComponent<Rigidbody2D>();
	}
	void Start () {

		WarriorClass = GameObject.Find("character");
		wrr = WarriorClass.GetComponent<Warrior> ();

		JumpForce = wrr.GetJumpForce();//Warrior.Instance.GetJumpForce ();
		Debug.Log ("Jump Force for controller: " + JumpForce + " - success");
		speed = wrr.GetSpeed(); //Warrior.Instance.GetSpeed ();
		Debug.Log ("Speed for controller: " + speed + " - success");
	}
	void FixedUpdate()
	{
		CheckGroung ();
	}

	void Update () {
		if (Input.GetButton ("Horizontal"))
			Run ();
		if (IsGround && Input.GetButton ("Jump"))
			Jump ();
        if (speed != wrr.GetSpeed())
            speed = wrr.GetSpeed();
	}
	private void Run()
	{
		Vector3 direction = transform.right * Input.GetAxis ("Horizontal");
		transform.position = Vector3.MoveTowards (transform.position, transform.position + direction, speed* Time.deltaTime);
		if (direction.x > 0 && !FaceToRight)
			flip ();
		else if (direction.x < 0 && FaceToRight)
			flip();

	}
	private void Jump()
	{
		RB.AddForce (transform.up * JumpForce, ForceMode2D.Impulse);
	}
	private void flip()
	{
		FaceToRight = !FaceToRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
	private void CheckGroung()
	{
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, 1F);

		IsGround = colliders.Length > 1;
	}
}
