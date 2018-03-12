using UnityEngine;
using UnityEngine.SceneManagement;

public class Bars : MonoBehaviour {

    private float curHP = 0f;
    public GameObject barHP;
    GameObject WarriorClass;
    Warrior wrr;

    void Start()
    {
        WarriorClass = GameObject.Find("character");
        wrr = WarriorClass.GetComponent<Warrior>();
    }

    void Update () {
        if (curHP != wrr.GetHealth())
        {
            curHP = wrr.GetHealth(); //Warrior.Instance.GetHealth ();
            if (curHP <= 0)
                SceneManager.LoadScene("Scene1");
            Debug.Log("Jump Force for controller: " + curHP + " - success");
            barHP.transform.localScale = new Vector3(curHP / 100, 1, 1);
        }
    }
}
