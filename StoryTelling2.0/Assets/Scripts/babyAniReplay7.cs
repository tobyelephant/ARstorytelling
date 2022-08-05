using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyAniReplay7 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator BabySparrowController_S7;

    public void settingfloating()
    {
        BabySparrowController_S7 = gameObject.GetComponent<Animator>();
        
        BabySparrowController_S7.Play("Base Layer.Float_S7", -1, 0f);
    }
}
