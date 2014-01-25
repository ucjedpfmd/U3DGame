namespace proto {
	public class m_pet_skill_forget_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] delete_skills;
		public int add_pet_skill_exp = 0;
		public m_pet_skill_forget_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_forget";
		}
		public override string getClassName() {
			return "m_pet_skill_forget_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"delete_skills", "array", "p_pet_skill"},new string[] {"add_pet_skill_exp", "int", "null"}};
		}
	}
}
