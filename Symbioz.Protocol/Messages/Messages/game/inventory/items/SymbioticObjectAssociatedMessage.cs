


















// Generated on 06/04/2015 18:45:07
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class SymbioticObjectAssociatedMessage : Message
{

public const ushort Id = 6527;
public override ushort MessageId
{
    get { return Id; }
}

public uint hostUID;
        

public SymbioticObjectAssociatedMessage()
{
}

public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(hostUID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

hostUID = reader.ReadVarUhInt();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            

}


}


}