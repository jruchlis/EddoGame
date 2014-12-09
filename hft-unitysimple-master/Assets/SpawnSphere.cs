using UnityEngine;
using System.Collections;

public class SpawnSphere : MonoBehaviour {
	int nSpheres = 0;
	//int nCubes = 0;


	public GameObject spherePrefab;
	public GameObject cubePrefab;
	public GameObject startPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown("z"))
		{
			GameObject newSphere = (GameObject) Instantiate(spherePrefab);
			newSphere.transform.position = startPosition.transform.position + new Vector3(0, nSpheres * .5f, 0);

				nSpheres++;
		}

		if (Input.GetKeyDown("x"))
		{
			GameObject newCube = (GameObject) Instantiate(cubePrefab);
			newCube.transform.position = startPosition.transform.position + new Vector3(0, nSpheres * .5f, 0);

			nSpheres++;
			//nCubes = nCubes+1;//same as nCubes++; and same as nCubes+=1;
		}*/

		GameObject newObject = null;
		if (Input.GetKeyDown("z"))
		{
			newObject = (GameObject) Instantiate(spherePrefab);

		}

		if (Input.GetKeyDown("x"))
		{
			newObject = (GameObject) Instantiate(cubePrefab);
		}

		/*if (Input.GetKeyDown("c"))
		{
			newObject = (GameObject) Instantiate(cylinderPrefab);
		}
		*/

		
		if (newObject !=null)
		{
			newObject.transform.position = startPosition.transform.position + new Vector3(0, nSpheres * 1.5f, 0);
			
			nSpheres++;
			//nCubes = nCubes+1;//same as nCubes++; and same as nCubes+=1;
		}

	}
}
