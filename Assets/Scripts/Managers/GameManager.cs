using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int numOfObjToFind = 1;
    List<GameObject> objectsFound = new List<GameObject>();

    public void FoundObject(GameObject foundObject)
    {
        if (!objectsFound.Contains(foundObject))
            objectsFound.Add(foundObject);

        Debug.Log(objectsFound.Count);

        if (objectsFound.Count >= numOfObjToFind)
        {
            //Win Condition
            Debug.Log("You have won the hunt!");
            SceneManager.LoadScene("EndScene");
        }


    }
}
