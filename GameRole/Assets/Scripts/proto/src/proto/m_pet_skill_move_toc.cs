namespace proto {
	public class m_pet_skill_move_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] del_skills;
		public object[] update_skills;
		public int op_type = 0;
		public m_pet_skill_move_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_move";
		}
		public override string getClassName() {
			return "m_pet_skill_move_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"del_skills", "array", "p_pet_skill"},new string[] {"update_skills", "array", "p_pet_skill"},new string[] {"op_type", "int", "null"}};
		}
	}
}
