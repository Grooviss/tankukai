using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Health player1;
    public Health player2;

    // Update is called once per frame
    void Update()
    {
        if (player1.hp == 0 || player2.hp == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
