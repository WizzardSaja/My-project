using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
     public float moveSpeed = 5f ;    // سرعة الحركة
    public float scaleSpeed = 0.5f ; // سرعة تغيير الحجم

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // تحريك الكائن باستخدام الأسهم
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveX, moveY, 0);
  
    }
}
