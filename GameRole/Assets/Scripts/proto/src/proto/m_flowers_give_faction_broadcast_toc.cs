namespace proto {
	public class m_flowers_give_faction_broadcast_toc : Message
	{
		public p_flowers_give_broadcast_info broadcast = null;
		public m_flowers_give_faction_broadcast_toc() {
		}
		public override string getMethodName() {
			return "flowers_give_faction_broadcast";
		}
		public override string getClassName() {
			return "m_flowers_give_faction_broadcast_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"broadcast", "p_flowers_give_broadcast_info", "null"}};
		}
	}
}
