using System;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	[SerializeField] float torqueAmount = 5f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
	Rigidbody2D rb2d;
	SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;

	//Use this for initialization
	void Start() 
	{
		rb2d = GetComponent<Rigidbody2D>();
		surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
	}

    //Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
        if
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}