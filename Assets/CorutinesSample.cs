using System.Collections;
using UnityEngine;

public class CorutinesSample : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(timer());
    }
    private IEnumerator timer()
    {
        for(int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(i);
        }
    }
}
