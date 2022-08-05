using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatBoolSetting : MonoBehaviour
{
    // Start is called before the first frame update
    Animator BabySparrowController_S6;

    public void settingfloating()
    {
        BabySparrowController_S6 = gameObject.GetComponent<Animator>();
       
        BabySparrowController_S6.Play("Base Layer.Float_S6", -1, 0f);
    }

    // Update is called once per frame
//     void Update()
//     {
//         floating = true;
//     }
    }
