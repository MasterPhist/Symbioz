


















// Generated on 06/04/2015 18:44:34
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class PartyCancelInvitationMessage : AbstractPartyMessage
{

public const ushort Id = 6254;
public override ushort MessageId
{
    get { return Id; }
}

public uint guestId;
        

public PartyCancelInvitationMessage()
{
}

public PartyCancelInvitationMessage(uint partyId, uint guestId)
         : base(partyId)
        {
            this.guestId = guestId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteVarUhInt(guestId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            guestId = reader.ReadVarUhInt();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            

}


}


}