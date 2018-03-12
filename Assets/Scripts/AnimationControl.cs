using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

	private Animator animator;
	//private SpriteRenderer sprite;
	private CHState State
	{
		get { return (CHState)animator.GetInteger  ("State");}
		set { animator.SetInteger ("State", (int)value);}
	}

	void Awake(){
		animator = GetComponent<Animator> ();
	}
	void Start () {
		
	}

	void Update () {
		State = CHState.Stand;
		Vector3 direction = transform.right * Input.GetAxis ("Horizontal");
		if (direction.x != 0)
			State = CHState.Walk;
		else if (direction.x == 0)
			State = CHState.Stand;
		if (Input.GetButtonDown("Jump"))
			State = CHState.Jump;
	}
}
public enum CHState
{ Stand, Walk, Run, Jump }