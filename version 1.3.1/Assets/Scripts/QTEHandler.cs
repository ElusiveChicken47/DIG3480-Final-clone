using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTEHandler : MonoBehaviour
{
    
    public GameObject QTEDisplay;
    public int waiting = 0;
    public bool YN = false;

    // Update is called once per frame
    void Update()
    {
        if(waiting == 1 && Input.GetKeyDown(KeyCode.E))
        {
            YN = true;
            waiting = 0;
        }
    }

    public bool Check()
    {
        Debug.Log("called");
        QTEDisplay.SetActive(true);
        waiting = 1;
        StartCoroutine(Wait());
        waiting = 0;
        
        return YN;
    }

    IEnumerator Wait()
    {
        for(int i = 0; i < 10; ++i)
        {
            if(waiting == 1)
            {
                yield return new WaitForSeconds(0.3f);
            }
            else
            {
                i = 11;
            }
        }
        
    }
}
