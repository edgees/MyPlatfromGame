using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBoxRecorder : MonoBehaviour
{
    public int box;
    public Text boxtext;
    private spawner _spawner;
    // Start is called before the first frame update
    void Start()
    {
        _spawner = GetComponent<spawner>();
        box = 0;
    }

    // Update is called once per frame
    void Update()
    {
        box = _spawner.CanSpawn - 1;
        if (box <= 0)
            box = 0;
        boxtext.text = ("Box: " + box);

    }

}
