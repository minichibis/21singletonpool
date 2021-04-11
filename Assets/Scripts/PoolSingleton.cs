using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolSingleton : MonoBehaviour
{
	public Pool[] pools = new Pool[2];
	static PoolSingleton thesingleton;
	public GameObject prefab1;
	public GameObject prefab2;
	
    // Start is called before the first frame update
    void Start()
    {
        pools[0] = new Pool();
		pools[0].prefab = prefab1;
		pools[0].pooly = new GameObject[pools[0].size];
		pools[1] = new Pool();
		pools[1].prefab = prefab2;
		pools[1].size = 3;
		pools[1].pooly = new GameObject[pools[1].size];
		PoolFill();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
			PoolSpawn(0);
		} else if (Input.GetKeyDown(KeyCode.W)){
			PoolSpawn(1);
		} if (Input.GetKeyDown(KeyCode.R)){
			PoolWipe();
		}
    }
	
	public void PoolSpawn(int i){
		pools[i].Spawn();
	}
	
	public void returnToPool(GameObject g){
		foreach(Pool p in pools){
			foreach(GameObject j in p.pooly){
				if(g == j){
					g.SetActive(false);
				}
			}
		}
	}
	
	public void PoolFill(){
		foreach(Pool p in pools){
			p.Fill();
		}
	}
	
	public static PoolSingleton getSingleton(){
		if (thesingleton == null){
			GameObject g = new GameObject();
			g.AddComponent<PoolSingleton>();
			thesingleton = g.GetComponent<PoolSingleton>();
		}
		return thesingleton;
	}
	
	public void PoolWipe(){
		foreach(Pool p in pools){
			p.Wipe();
		}
	}
}
