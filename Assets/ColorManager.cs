﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour {

    public Color color;
	
    void OnColorChange(HSBColor color) {
        this.color = color.ToColor();
    }
    
}
