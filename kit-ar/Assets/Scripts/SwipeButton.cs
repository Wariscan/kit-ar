using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeButton : MonoBehaviour
{
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[] pos;
    int positon = 0;
    public GameObject prevButton, nextButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void next()
    {
        if(positon < pos.Length - 1)
        {
            positon += 1;
            scroll_pos = pos[positon];
        }
    }

    public void prev()
    {
        if (positon > 0)
        {
            positon -= 1;
            scroll_pos = pos[positon];
        }
    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }  
        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        } else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos [i] + (distance /2) && scroll_pos > pos [i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.15f);
                    positon = i;
                }
            }
        }

        
    }
}
