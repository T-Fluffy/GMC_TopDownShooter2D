using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disabledOnDeath;
    public float health=100f;
        
    public void TakeDamage(float amount){
	    health -= amount; 
	    if(health <= 0)
	    {
		    health = 0;
		    Die();
	    }
    }
    public void Die(){
	//Disable all the components inside the disableOnDeath array that you will assign from the inspector
	    foreach(Behaviour behaviour in disabledOnDeath)
	    {
			behaviour.enabled = false;
	    }
    }
}
