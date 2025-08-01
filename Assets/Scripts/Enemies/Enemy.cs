using System.ComponentModel;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int currenthealth;
    private int maxHealth = 30;
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

    public void TakeDamage(int amount)
    {
        if (!isDead)
        {
            currenthealth -= amount;
            if (currenthealth <= 0)
            {
                isDead = true;
                Destroy(gameObject);
            }
        }
    }
}
