using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force = 1500;
    public float speed = 25;
    public float maxx;
    public float minx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x, minx, maxx);
        transform.position = playerpos;
       /* if (playerpos.x<minx)
        {
            playerpos.x = minx;
        }
        if (playerpos.x > maxx)
        {
            playerpos.x = maxx;
        }

*/
        
       
       

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed* Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed* Time.deltaTime,0,0);
        }
    }
    private void FixedUpdate()
    {
    rigidbody.AddForce(0, 0, force*Time.deltaTime);
        //speed = speed * Time.deltaTime * 2;
    }
}
