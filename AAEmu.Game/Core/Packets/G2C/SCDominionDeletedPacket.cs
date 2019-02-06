using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCDominionDeletedPacket : GamePacket
    {
        private readonly ushort _id;

        public SCDominionDeletedPacket(ushort id) : base(0x01b, 1)
        {
            _id = id;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_id);
            return stream;
        }
    }
}
