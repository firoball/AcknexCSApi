using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acknex3.Api
{
    public interface ILevelObject
    {
        Var X { get; set; }
        Var Y { get; set; }
        
        void Locate();
        void Drop();
        void Place();
        void Explode();
        void Shake();
        
        //TODO: add mandatory parameters for distinguishing
        //IsThing, IsActor, IsWall -> THING/ACTOR Flags
    }
}
