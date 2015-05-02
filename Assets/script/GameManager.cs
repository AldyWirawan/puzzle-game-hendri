using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    // public

    // sprite
    public Sprite red;
    public Sprite green;
    public Sprite blue;

    // cara bodoh
    public List<GameObject> tilePos;
    public List<GameObject> probPos;
    
    // private

    private Vector3 baseTileLocation;
    private int tileSize;
    private int[] tile;
    private int[] problem;

    // counter
    private int problemCounter;

    // cara pintar
    // private Vector3[] tilePos;

	// Use this for initialization
	void Start () {
        instance = this;
        problemCounter = 0;
        initTile();
        generateTile();
        generateProblem();
        Debug.Log(problem[0]);
        Debug.Log(problem[1]);
        Debug.Log(problem[2]);
        Debug.Log(problem[3]);
	}

    void initTile()
    {
        tileSize = 4;
        tile = new int[tileSize];
        problem = new int[tileSize];
        //tilePos = new Vector3[tileSize];
        baseTileLocation = new Vector3(0, 0, 0);
        for (int i = 0; i < tile.Length; i++)
        {
            tile[i] = UnityEngine.Random.Range(1, 4);
        }
        for (int i = 0; i < problem.Length; i++)
        {
            problem[i] = i;
        }
    }

    void generateTile()
    {
        for (int i = 0; i < tile.Length; i++)
        {
            tilePos[i].AddComponent<SpriteRenderer>();
            if (tile[i] == 1) {
                tilePos[i].GetComponent<SpriteRenderer>().sprite = red;
            } else if (tile[i] == 2) {
                tilePos[i].GetComponent<SpriteRenderer>().sprite = green;
            } else if (tile[i] == 3) {
                tilePos[i].GetComponent<SpriteRenderer>().sprite = blue;
            }
        }
    }

    void generateProblem()
    {
        for (int i = 0; i < problem.Length; i++)
        {
            int temp = problem[i];
            int randomIndex = Random.Range(i, problem.Length);
            problem[i] = problem[randomIndex];
            problem[randomIndex] = temp;
        }

        for (int i = 0; i < problem.Length; i++)
        {
            // sekarang problem isinya indeks tile!

            probPos[i].AddComponent<SpriteRenderer>();
            
            if (tile[problem[i]] == 1)
            {
                probPos[i].GetComponent<SpriteRenderer>().sprite = red;
            }
            else if (tile[problem[i]] == 2)
            {
                probPos[i].GetComponent<SpriteRenderer>().sprite = green;
            }
            else if (tile[problem[i]] == 3)
            {
                probPos[i].GetComponent<SpriteRenderer>().sprite = blue;
            }
        }
    }

    // setter getter

    public int[] getTile()
    {
        return tile;
    }

    public int[] getProblem()
    {
        return problem;
    }

    public int getProbCounter()
    {
        return problemCounter;
    }

    public void increaseProbCounter()
    {
        problemCounter++;
    }
	
	// Update is called once per frame
	void Update () {

	}
}
