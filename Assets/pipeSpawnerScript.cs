using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=2;
    public float timer=0;
    public float heightOffset =8;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate){
            timer+=Time.deltaTime;
        }else{
            spawnPipe();
            timer=0;
        }
        
    }

    void spawnPipe(){
        float lowestPoint = transform.position.y-heightOffset;
        float heighestPoint = transform.position.y+heightOffset;

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,heighestPoint),0),transform.rotation);
    }
}
