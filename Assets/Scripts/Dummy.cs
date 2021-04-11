using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
	public GameObject p1;
	public GameObject p2;
	
	
    // Start is called before the first frame update
    void Start()
    {
        PoolSingleton.getSingleton().prefab1 = p1;
		PoolSingleton.getSingleton().prefab2 = p2;
    }
}
