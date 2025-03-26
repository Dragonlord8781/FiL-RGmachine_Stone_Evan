using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    public bool canMove;
    //sets speed, startPoint, and Transform[] points
    [SerializeField] float speed;
    [SerializeField] int startPoint;
    [SerializeField] Transform[] points;

    //declares i and reverse
    int i;
    bool reverse;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // sets starting position
       transform.position  = points[startPoint].position;
        i = startPoint;
    }

    // Update is called once per frame
    void Update()
    {
        // sets if the platform its not where its supposed to be it get fixed
        if(Vector3.Distance(transform.position, points[i].position) < 0.01f)
        {
            canMove = false;

            if(i == points.Length - 1)
            {
                reverse = true;
                i--;
                return;
            } else if (i == 0)
            {
                reverse = false;
                i++;
                return;
            }

            if (reverse)
            {
                i++;
            }
        }
        // if it can move it moves how an elevator moves
        if (canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        }
    }
}
