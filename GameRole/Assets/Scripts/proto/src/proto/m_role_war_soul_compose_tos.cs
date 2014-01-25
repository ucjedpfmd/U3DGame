namespace proto {
	public class m_role_war_soul_compose_tos : Message
	{
		public int suit_id = 0;
		public m_role_war_soul_compose_tos() {
		}
		public override string getMethodName() {
			return "role_war_soul_compose";
		}
		public override string getClassName() {
			return "m_role_war_soul_compose_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"suit_id", "int", "null"}};
		}
	}
}
