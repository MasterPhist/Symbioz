


















// Generated on 06/04/2015 18:44:18
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GameContextRemoveElementMessage : Message
{

public const ushort Id = 251;
public override ushort MessageId
{
    get { return Id; }
}

public int id;
        

public GameContextRemoveElementMessage()
{
}

public GameContextRemoveElementMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(ICustomDataInput reader)
{

id = reader.ReadInt();
            

}


}


}