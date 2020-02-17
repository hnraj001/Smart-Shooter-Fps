using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
	public int minutesInDay = 12;
	float deg;
	// Start is called before the first frame update
	void Start()
    {
		deg = 360 / (minutesInDay * 60);	
	}

    // Update is called once per frame
    void Update()
    {
			transform.RotateAround(Vector3.zero, Vector3.right, deg * Time.deltaTime);
			transform.LookAt(Vector3.zero);	
    }
}
