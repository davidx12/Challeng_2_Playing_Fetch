using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public Timer newTimer = new Timer();
    public int measureTime = 1;

    // Update is called once per frame
    void Update()
    {

        newTimer.Interval = 6;
        newTimer.Elapsed += new ElapsedEventHandler(TimeStart);
        newTimer.Enabled = true;
        newTimer.Start();

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & measureTime > 3)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            measureTime = 1;
            newTimer.Stop();
        }
    }

    private void TimeStart(object o, ElapsedEventArgs e)
    {
        measureTime++;
    }
}
