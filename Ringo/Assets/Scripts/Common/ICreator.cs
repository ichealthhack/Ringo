using System.Collections;

namespace Assets.Scripts.Common
{
    internal interface ICreator
    {
        IEnumerator Run();
        UnityEngine.Object Create();
    }
}