using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public GameObject DeathEffectObj;
	
	private void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.tag == "Enemy")
    	{

    		GameObject effectObj = Instantiate(DeathEffectObj, collision.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(collision.gameObject);
            addScore();
    		
    	}
	}

    void addScore()
    {
        GameObject.Find("GameManager").GetComponent<ScoreManager>().AddScore();
    }

}
