using UnityEngine;

using System.Collections;

using Vuforia;


public class actionScript : MonoBehaviour, IVirtualButtonEventHandler {


	// Use this for initialization
	
private GameObject vbButtonObject;
private GameObject zombie;
void Start () 
{

	vbButtonObject = GameObject.Find("actionButton");
	zombie = GameObject.Find("zombie");
	vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
}
	
	

public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
{
	zombie.GetComponent<Animation>().Play();
}

public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
{
	zombie.GetComponent<Animation>().Stop();
}

}
