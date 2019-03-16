using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscroll : MonoBehaviour
{

	Material material;
	Vector2 offset;
	public float xVelocity;
	public float yVelocity;

	void Awake()
	{
		material = GetComponent<Renderer>().material;
	}


	void Start()
    {
       
    }

    void Update()
    {
		offset = new Vector2(xVelocity, yVelocity);

		material.mainTextureOffset += offset * Time.fixedDeltaTime;

    }
}
