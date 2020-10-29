using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMask : MonoBehaviour
{
    public float speed;
    public float OffsetR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Input.mousePosition;
        mousepos.z = 0;
        Vector3 objectpos = Camera.main.WorldToScreenPoint(transform.position);

        mousepos.x = mousepos.x - objectpos.x;
        mousepos.y = mousepos.y - objectpos.y;

        float angle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - OffsetR));

        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    }
}
