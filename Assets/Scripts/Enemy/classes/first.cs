using UnityEngine;

public class first : MonoBehaviour
{
    private Rigidbody2D rb;
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
            Debug.Log("HIT IT(ENEMY)");
            curHP = wrr.GetHealth();
            rb = other.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * 300);
            curHP = curHP - 1;
            wrr.SetHealth(curHP);
        }
    }
}