using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_movement : MonoBehaviour
{
	public float velocity;
	private Rigidbody2D p_rb;
	private Vector3 change;
	//p_rb : Rigidbody2D of the player
    // Start is called before the first frame update
    void Start()
    {
        p_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     change = Vector3.zero;   
	 change.x = Input.GetAxisRaw("Horizontal");
	 change.y = Input.GetAxisRaw("Vertical");
	 Debug.Log(change);
	 if(change != Vector3.zero)
	 {
		p_move();
	 }		
    }
	
	void p_move()
	{
	
     p_rb.MovePosition( transform.position + change * velocity * Time.deltaTime );	
	
	}
}
