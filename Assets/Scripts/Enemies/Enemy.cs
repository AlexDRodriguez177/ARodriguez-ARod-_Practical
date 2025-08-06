using System.ComponentModel;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int currenthealth;
    public int maxHealth = 30;
    public int damage = 10; 
    public int scoreValue = 5;

    private bool isDead = false;

    void Start()
    {
        currenthealth = maxHealth;
    }

 
    void Update()
    {
        
    }

    public void AttackPlayer(PlayerHealth playerHealth)
    {
        playerHealth.PlayerTakeDamage(damage);
    }

    public void TakeDamage(int amount)
    {
        if (!isDead)
        {
            currenthealth -= amount;
            if (currenthealth <= 0)
            {
                isDead = true;
                ScoreManager.score += scoreValue;
                ScoreManager.Instance.ShowScore();
                Destroy(gameObject);
            }
        }
    }
}
