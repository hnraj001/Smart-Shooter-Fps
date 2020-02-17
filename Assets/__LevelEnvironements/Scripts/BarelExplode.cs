using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarelExplode : MonoBehaviour
{

	GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
		explosion = transform.Find("Explosion").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void Explode()
	{
		Debug.Log("Exploding");
		explosion.SetActive(true);

		GetComponent<AudioSource>().Play();
		Destroy(GetComponent<MeshRenderer>());
		Destroy(explosion, 4);
		Destroy(gameObject, 5);
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name.Contains("Bullet"))
		{
			Explode();
		}
	}
}
