using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int health=100;
    
	public bool TakeDamage(int n)
	{
		health -= n;
		return (health > 0);
	}
}
