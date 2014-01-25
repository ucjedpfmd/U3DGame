namespace proto {
	public class m_role_show_equip_ring_tos : Message
	{
		public bool show_equip_ring = true;
		public m_role_show_equip_ring_tos() {
		}
		public override string getMethodName() {
			return "role_show_equip_ring";
		}
		public override string getClassName() {
			return "m_role_show_equip_ring_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"show_equip_ring", "bool", "null"}};
		}
	}
}
