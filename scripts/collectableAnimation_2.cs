using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableAnimation : MonoBehaviour
{

	public float verticalSpeed;
	public float amplitude;

	public Vector3 tempPosition;

    // Start is called before the first frame update
    void Start()
    {
       tempPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed)* amplitude + 1;
        transform.position = tempPosition;
        transform.Rotate (new Vector3 (0, 0, 30) * Time.deltaTime);
    }
}
