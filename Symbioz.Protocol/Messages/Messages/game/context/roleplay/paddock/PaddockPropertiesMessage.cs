


















// Generated on 06/04/2015 18:44:32
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class PaddockPropertiesMessage : Message
{

public const ushort Id = 5824;
public override ushort MessageId
{
    get { return Id; }
}

public Types.PaddockInformations properties;
        

public PaddockPropertiesMessage()
{
}

public PaddockPropertiesMessage(Types.PaddockInformations properties)
        {
            this.properties = properties;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

properties = Types.ProtocolTypeManager.GetInstance<Types.PaddockInformations>(reader.ReadShort());
            properties.Deserialize(reader);
            

}


}


}