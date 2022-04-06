using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jotaro : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealth;
    public Animator animator;
    public GameObject banner;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void Takedamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void EndAnimation()
    {
        if (currentHealth <= 0)
        {
            banner.GetComponent<EndGame>().DioWin(true);
        }
    }
    void Die()
    {
        animator.SetBool("IsDie", true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
    public void InStopTime(bool JotaroStop)
    {
        if (JotaroStop ==true)
        {
            //this.enabled = false;
            //Debug.Log("Thats Ok, it's worked");
            animator.SetBool("JotaroStop", true);
        }
        else if( JotaroStop == false)
        {
            animator.SetBool("JotaroStop", false);
        }
    }
}
