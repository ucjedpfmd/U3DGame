namespace proto {
	public class m_pet_skill_preview_toc : Message
	{
		public int err_code = 0;
		public object[] preview_skills;
		public object[] preview_reward;
		public m_pet_skill_preview_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_preview";
		}
		public override string getClassName() {
			return "m_pet_skill_preview_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"preview_skills", "array", "int"},new string[] {"preview_reward", "array", "int"}};
		}
	}
}
