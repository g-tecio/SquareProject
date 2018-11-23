using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObst : MonoBehaviour {

	public GameObject DeathEffectObj;
	
	private void OnCollisionEnter2D(Collision2D collision){

    	if (collision.gameObject.tag == "Player")
    	{

    		GameObject effectObj = Instantiate(DeathEffectObj, collision.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(collision.gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
            GameObject.Find("DestroyEnemy").GetComponent<BoxCollider2D>().enabled = false;
    		
    	}
	}
	

}
