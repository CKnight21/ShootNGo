using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //When enemy 1, enemy 2, enemy 3,... are destroyed go to next level.
    //or when enemies are destroyed go to next level.

    public string nextLevel;
    public int LevelIndex;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(nextLevel);
    }

    int level;


}
