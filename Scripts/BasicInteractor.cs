﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BasicInteractor : XRBaseControllerInteractor
{
    public override void GetValidTargets(List<XRBaseInteractable> validTargets) { }

    protected override List<XRBaseInteractable> validTargets { get; }

}
