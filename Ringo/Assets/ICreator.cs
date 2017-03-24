using System.Collections;

internal interface ICreator
{
    IEnumerator Run();
    UnityEngine.Object Create();
}