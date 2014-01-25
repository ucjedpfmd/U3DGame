namespace proto {
	public class m_skill_learn_tos : Message
	{
		public int skill_id = 0;
		public bool auto_buy = true;
		public m_skill_learn_tos() {
		}
		public override string getMethodName() {
			return "skill_learn";
		}
		public override string getClassName() {
			return "m_skill_learn_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"},new string[] {"auto_buy", "bool", "null"}};
		}
	}
}
