using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class Score : MonoBehaviour
{
    public TMP_Text tmpT;
    // Start is called before the first frame update
    void Awake()
    {
        tmpT = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tmpT.text = "High Score: " + Main.highScore + "\nScore: " + Main.score;
    }
}
