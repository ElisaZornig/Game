using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Text Health;
    public Text Losetext;
    public Stat damage;
    public Stat armor;
    public GameObject button;
    
    
       


    void Start() {

        SetHealth();
        Losetext.text = "";
    }

    void Awake() {

        currentHealth = maxHealth;

    }

    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("Enemy")) {
            TakeDamage(10);
            Debug.Log(transform.name + "Collision");
            SetHealth();

        }
    }

    public void TakeDamage(int damage) {

        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0) {

            Die();
        }
    }


    void SetHealth()
    {
        Health.text = "Your Health:" + currentHealth.ToString();
        if (currentHealth <= 0)
        {
            
            Losetext.text = "You Lose!";
            button.SetActive(true);
        }
    }

    public virtual void Die() {
        //Die in some way
        //This method is meant to be overwritten
        Debug.Log(transform.name + " died.");

    }
}
