using UnityEngine;

public class Fire : MonoBehaviour {
    GameObject WarriorClass;
    Warrior wrr;
    private int curHP = 0;
    void Start()
    {
        WarriorClass = GameObject.Find("character");
        wrr = WarriorClass.GetComponent<Warrior>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            curHP = wrr.GetHealth();
            curHP = curHP - 1;
            wrr.SetHealth(curHP);
        }
    }
}
