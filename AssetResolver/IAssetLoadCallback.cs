﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using SgUnity;

public interface IAssetLoadCallback<T>  {
   void assetLoadSuccess(T asset);
   void assetLoadFailed();
}
