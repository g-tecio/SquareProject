using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public int numObjects;
    public GameObject obj1;

    public float minRn ;

    public float maxRn;

    public float posY;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            SpawnObj();
        }

    }

    public void SpawnObj()
    {
        Vector2 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            Vector2 pos = obstacle(center);
            GameObject childObject = Instantiate(obj1, pos,  Quaternion.identity); //as GameObject;
            childObject.transform.parent = transform;
        }
    }

    public void GenNum(int minNum, int maxNum){
 
    }


    Vector2 obstacle(Vector2 center)
    {
        
        Vector2 pos;
        float space = Random.Range(minRn , maxRn);

        pos.x = space;
        pos.y = posY;

        return pos;
        //if(space % 2 != 0){

        //    pos.x = (space);
        //    pos.y = posY;

        //    return pos;

        //}else{
        //    pos.x = (space + minRn);
        //    pos.y = posY;

        //    return pos;
        //}  
    }
}