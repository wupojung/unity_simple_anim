using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdHandler : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;
    // sprites 名字定義分別如下 
    // 00 01 02 03  DOWN
    // 04 05 06 07  LEFT
    // 08 09 10 11  RIGHT
    // 12 13 14 15  UP    
      

    private int index;

    //若我們可取得 0 1 2 3 順序, 若 + 4 則可以得到 4 5 6 7 (即 LEFT 的動作)
    private int offset; // up +12  down +0  left +4  right +8
      
    private int fixedUpdateCounter = 0; //計算時間

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            offset = 12;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            offset = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            offset = 4;
        }        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            offset = 8;
        }
    }

    private void FixedUpdate()
    {
        fixedUpdateCounter++;
        if (fixedUpdateCounter % 10 == 0)
        {
            //換圖
            index++;
            if (index >= 4)
            {
                index = 0;
            }

            image.sprite = sprites[index+offset];
        }
    }

}
