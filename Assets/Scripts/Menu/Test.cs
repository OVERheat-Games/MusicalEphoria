using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public static Test Instance  {get; private set; }
    public int Scores;

	public void Awake()
	{
		Instance = this;
    }
}
