using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide: MonoBehaviour
{
<<<<<<< Updated upstream

    public string objName;
=======
    
>>>>>>> Stashed changes
    public int i;
    public Renderer rend;

    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
<<<<<<< Updated upstream
=======
        blueHide = Random.Range(200, 250);// generate a random int between 200 to 250
        
        if (this.tag == "Blue")// print out the real value for blue ball to deactivate
        {
            Debug.Log("blueHide is " + blueHide);
        }
        
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        i++;
<<<<<<< Updated upstream
        Debug.Log(objName + i);
=======
        Debug.Log(this.name + ":" + i);// print out the required name and frame. Format (objName: i);
        
        if (this.tag == "Red" & i == 100){// deactivate read ball on 100th frame
            //this.SetActive(false); 
            //GameObject.Find("Red").SetActive(false);
            //rend.SetActive(false);
        }
        
        if (this.tag == "Blue" & i == blueHide){// deactive blue ball on "blueHide"th frame
            //this.SetActive(false);
            //GameObject.Find("Blue").SetActive(false);
        }
        
>>>>>>> Stashed changes
    }
}
