using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEditor
{
class EditorUtils {
[MenuItem("Game/Set Custom Ammo Type")]
static void SetCustomAmmoType()
{
if (Selection.objects.Length > 0)
{
var tr = Selection.objects[0] as AmmoProto;
tr.Type = (AmmoType)999;
EditorUtility.SetDirty(tr);
}
}
}
}