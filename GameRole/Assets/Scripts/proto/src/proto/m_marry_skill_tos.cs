namespace proto {
	public class m_marry_skill_tos : Message
	{
		public int skill_id = 0;
		public m_marry_skill_tos() {
		}
		public override string getMethodName() {
			return "marry_skill";
		}
		public override string getClassName() {
			return "m_marry_skill_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"}};
		}
	}
}
