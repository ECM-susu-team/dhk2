using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeCharacter : BaseObject {

	protected int health;
	protected float jumpForce;
    public int GetHealth(){
		return health;
	}
	public void SetHealth(int _health) {
		health = _health;
	}
	public float GetJumpForce(){
		return jumpForce;
	}
	public void SetJumpForce (float _force){
		jumpForce = _force;
	}
	public virtual void Attack (){
	
	}
}
