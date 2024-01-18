using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public logicMgrScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicMgrScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y<-50 ){
            Debug.Log("Bird fall over");
            logic.gameOver();
            birdIsAlive=false;
            Vector3 newPos = new Vector3(0,0,0);
            gameObject.transform.position = newPos;
        }
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidbody2D.velocity=Vector2.up*6;
        }
        
    }

    private void onCollisionEnter2D(Collision2D collision){
        Debug.Log("Bird collides");
        logic.gameOver();
        birdIsAlive=false;

    }
}
