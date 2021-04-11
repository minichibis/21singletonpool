using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool
{
	public int size = 5;
	public GameObject[] pooly;
	public GameObject prefab;
	
    // Start is called before the first frame update
    void Start()
    {
        pooly = new GameObject[5];
    }
	
	public void Spawn(){
		
		foreach (GameObject g in pooly){
			if (!g.activeSelf){
				g.SetActive(true);
				g.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), -1);
				break;
			}
		}
	}
	
	public void Fill(){
		for(int i = 0; i < size; i++){
			pooly[i] = GameObject.Instantiate(prefab);
			pooly[i].SetActive(false);
		}
	}
	
	public void Wipe(){
		for(int i = 0; i < size; i++){
			pooly[i].SetActive(false);
		}
	}
}
