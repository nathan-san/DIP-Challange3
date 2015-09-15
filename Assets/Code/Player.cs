using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float m_score = 0;
	public float speed = 4;
	public bool rot = false;
    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime * speed;
		if (rot)
		{
			this.transform.Rotate (0f,0f,1f);
		}
    }
}
