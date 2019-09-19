using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narratetext : MonoBehaviour
{

	public InputField story;
	public Text allstory;

	public void setget(){
		allstory.text = allstory.text + "  " + story.text;
	}
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
