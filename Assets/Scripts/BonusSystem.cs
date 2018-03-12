using UnityEngine;

public class BonusSystem : MonoBehaviour{

    public int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            this.score++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.name == "DieSpace")
        {
            this.score = 0;
        }
        if (other.gameObject.tag == "CoinX2")
        {
            this.score = this.score + 2;
            other.gameObject.SetActive(false);
        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 100), "Score: " + score);
    }
}
