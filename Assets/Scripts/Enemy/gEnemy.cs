using UnityEngine;
using System.Collections;

public class gEnemy : MonoBehaviour
{

    [System.Serializable]
    public class EnemyStats
    {
        public int damage;
        // TODO: change to FLOAT as avaible;
        public float starthpmultiplier = 1f;
        private float _maxHealth;
        public float maxHealth 
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        private float _curHealth;
        public float curHealth
        {
            get { return _curHealth; }
            set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
        }

        public EnemyStats()
        {
          damage = 10;
          _maxHealth = 100;
            maxHealth = _maxHealth;
          _curHealth = maxHealth*starthpmultiplier;
            curHealth = _curHealth;
        }
    }
    public EnemyStats stats = new EnemyStats();
 
    public static void KillEnemy(gEnemy other)
    {
        Destroy(other.gameObject);
    }
    public void DamageEnemy(int damage)
    {
        Debug.Log("PlayerHitsEnemy");
        stats.curHealth -= damage;
        if (stats.curHealth <= 0)
        {
            KillEnemy(this);
        }
    }

    private void OnCollisionEnter2D (Collision2D _collinfo)
    {
        Warrior _player = _collinfo.collider.GetComponent<Warrior>();
        if (_player != null)
        {
            Debug.Log("EnemyHitsplayer for" + stats.damage);
            _player.SetHealth(_player.GetHealth()- stats.damage);
        }
    }
}

