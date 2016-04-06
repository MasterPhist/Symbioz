


















// Generated on 06/04/2015 18:45:36
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class Shortcut
{

public const short Id = 369;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte slot;
        

public Shortcut()
{
}

public Shortcut(sbyte slot)
        {
            this.slot = slot;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(slot);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

slot = reader.ReadSByte();
            if ((slot < 0) || (slot > 99))
                throw new Exception("Forbidden value on slot = " + slot + ", it doesn't respect the following condition : (slot < 0) || (slot > 99)");
            

}


}


}