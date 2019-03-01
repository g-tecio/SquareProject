using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionObst : MonoBehaviour {

	public GameObject DeathEffectObj, DeathEffectObjNeon;
	bool SkinNormal, SkinNeon, SkinBow;
	
	
	private void OnCollisionEnter2D(Collision2D collision){

    	if (collision.gameObject.tag == "Player" && SkinNeon == false)
    	{

    		GameObject effectObj = Instantiate(DeathEffectObj, collision.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(collision.gameObject);
			
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
            GameObject.Find("DestroyEnemy").GetComponent<BoxCollider2D>().enabled = false;

				//print("NORMAL SKIN IN COLLISION" + SkinNormal);
		//print("NEON SKIN IN COLLISION" + SkinNeon);
    		
    	}

		
		if (collision.gameObject.tag == "Player" && SkinNeon == true)
    	{

    		GameObject effectObj = Instantiate(DeathEffectObjNeon, collision.contacts[0].point, Quaternion.identity);
    		Destroy(effectObj, 1.5f);
    		Destroy(collision.gameObject);
			
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
            GameObject.Find("DestroyEnemy").GetComponent<BoxCollider2D>().enabled = false;
    		
    	}
	}

	void Update()
	{
		SkinNormal = GameObject.Find("SkinManager").GetComponent<SkinManager>().SkinNormal;
		SkinNeon = GameObject.Find("SkinManager").GetComponent<SkinManager>().SkinNeon;
		SkinBow = GameObject.Find("SkinManager").GetComponent<SkinManager>().SkinBow;
		//print("NORMAL SKIN IN COLLISION" + SkinNormal);
		//print("NEON SKIN IN COLLISION" + SkinNeon);

	}
	

}
