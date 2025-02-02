using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;



public class TakeShaurma : MonoBehaviour
{
    private float points;
    [SerializeField] private TextMeshProUGUI PointText;
    void Start()
    {
        points = 0;
        PointText.text = "Points: " + points.ToString();
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ShaurmaOne"))
        {
            Destroy(collision.gameObject);
            points += 5;
        }
            if (collision.gameObject.CompareTag("ShaurmaTwo"))
            {
                Destroy(collision.gameObject);
                points += 10;
            }
                if (collision.gameObject.CompareTag("ShaurmaThree"))
                {
                    Destroy(collision.gameObject);
                    points += 15;
                }
                    if (collision.gameObject.CompareTag("ShaurmaFour"))
                    {
                        Destroy(collision.gameObject);
                        points += 20;
                    }
        PointText.text = "Points: " + points.ToString();
    }
}
