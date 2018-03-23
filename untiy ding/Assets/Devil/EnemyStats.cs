using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour {
    public Text DevilHealth;
    public Text Wintext;
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public GameObject enemy;
	public GameObject WinButton;

    public Stat damage;
    public Stat armor;
    

    void Start()
    {

        SetHealth();
        Wintext.text = "";

    }
    void Awake()
    {

        currentHealth = maxHealth;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            TakeDamage(10);
            SetHealth();
        }
    }

    public void TakeDamage(int damage)
    {

        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0)
        {

            Die();
        }
    }
    void SetHealth()
    {
        DevilHealth.text = "Devil's Health:" + currentHealth.ToString();
        
        if(currentHealth <= 0)
        {
            enemy.SetActive(false);
            Wintext.text = "You Win!";
			WinButton.SetActive (true);
        }
    }
    public virtual void Die()
    {
        //Die in some way
        //This method is meant to be overwritten
        Debug.Log(transform.name + " died.");

    }
}
