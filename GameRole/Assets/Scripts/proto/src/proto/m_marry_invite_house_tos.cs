namespace proto {
	public class m_marry_invite_house_tos : Message
	{
		public object[] target_ids;
		public m_marry_invite_house_tos() {
		}
		public override string getMethodName() {
			return "marry_invite_house";
		}
		public override string getClassName() {
			return "m_marry_invite_house_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_ids", "array", "double"}};
		}
	}
}
