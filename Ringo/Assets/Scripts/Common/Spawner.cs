using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class Spawner : SpawnerBase
    {
        public GameObject creatable;

        public override UnityEngine.Object Create()
        {
            Vector3 position = this.Position();
            return Instantiate(this.creatable, position, Quaternion.identity);
        }
    }
}
