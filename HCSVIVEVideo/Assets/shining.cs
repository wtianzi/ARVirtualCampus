using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shining : MonoBehaviour
{
    private Color m_color;
    public float waittime=0.1f;
    private IEnumerator coroutine;
    // Start is called before the first frame update
    private void Start()
    {
        m_color = this.GetComponent<MeshRenderer>().material.color;
        //fadeSpeed = 10;
        coroutine = WaitAndPrint(waittime);
        StartCoroutine(coroutine);
    }
   
    IEnumerator WaitAndPrint(float waitTime)
    {
        int t = 1;
        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            if ((m_color.a >= 1) || (m_color.a <= 0))
                t = -1 * t;

            m_color.a += 0.1f* t;
            //Debug.Log(m_color);
            
            this.GetComponent<MeshRenderer>().material.color = m_color;
        }        
        
    }
}
