using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSFamilyInviteMemberPacket : GamePacket
    {
        public CSFamilyInviteMemberPacket() : base(0x019, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var name = stream.ReadString();
            var title = stream.ReadString();

            _log.Debug("FamilyInviteMember, Name: {0}, Title: {1}", name, title);
        }
    }
}
