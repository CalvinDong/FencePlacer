using ICities;
using UnityEngine;

namespace Tutorial
{

    public class FencePlacerMod : IUserMod
    {

        public string Name
        {
            get { return "Fence Placer Mod"; }
        }

        public string Description
        {
            get { return "Automatically places fences down in a selected area"; }
        }
    }
}
