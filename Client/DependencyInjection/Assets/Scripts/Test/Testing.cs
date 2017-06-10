using UnityEngine;
using System.Collections;

public class Testing : ITesting {

	public void Test(){
		Object.Instantiate(Resources.Load("Cube"));	
	}
}
