using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{
    public float maxHealth = 10;
    public float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        Healthbar(amount);
    }

    private void Healthbar(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0f)
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
