using UnityEngine;
using System.Collections;

public class tile : MonoBehaviour {

    Sprite currColor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(GameManager.instance.getProbCounter());
	}

    void OnMouseDown()
    {
        //Debug.Log("hai!");
        currColor = this.GetComponent<SpriteRenderer>().sprite;
        
        if (currColor == GameManager.instance.red)
        {
            //Debug.Log("red");
            if (GameManager.instance.getTile()[GameManager.instance.getProblem()[GameManager.instance.getProbCounter()]] == 1)
            {
                this.GetComponent<SpriteRenderer>().sprite = null;
                GameManager.instance.increaseProbCounter();
            }
        }

        if (currColor == GameManager.instance.green)
        {
            //Debug.Log("green");
            if (GameManager.instance.getTile()[GameManager.instance.getProblem()[GameManager.instance.getProbCounter()]] == 2)
            {
                this.GetComponent<SpriteRenderer>().sprite = null;
                GameManager.instance.increaseProbCounter();
            }
        }

        if (currColor == GameManager.instance.blue)
        {
            //Debug.Log("blue");
            if (GameManager.instance.getTile()[GameManager.instance.getProblem()[GameManager.instance.getProbCounter()]] == 3)
            {
                this.GetComponent<SpriteRenderer>().sprite = null;
                GameManager.instance.increaseProbCounter();
            }
        }

    }
}
