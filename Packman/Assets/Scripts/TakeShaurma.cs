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
        string collisionName = collision.gameObject.tag;
        switch (collisionName)
        {
            case "ShaurmaOne":
                PlusPoints(collision.gameObject, 5);
                break;
            case "ShaurmaTwo":
                PlusPoints(collision.gameObject, 10);
                break;
            case "ShaurmaThree":
                PlusPoints(collision.gameObject, 15);
                break;
            case "ShaurmaFour":
                PlusPoints(collision.gameObject, 20);
                break;
        }
        
    }
    private void PlusPoints(GameObject point,int score)
    {
        Destroy(point);
        points += score;
        PointText.text = "Points: " + points.ToString();
    }
}
