namespace proto {
	public class m_family_get_bounty_tos : Message
	{
		public int item_id = 0;
		public m_family_get_bounty_tos() {
		}
		public override string getMethodName() {
			return "family_get_bounty";
		}
		public override string getClassName() {
			return "m_family_get_bounty_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"item_id", "int", "null"}};
		}
	}
}
